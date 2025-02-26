using System.Threading.Tasks;
using Microsoft.Maui.Controls;

namespace DawrfWorkShopIdle
{
    public partial class MainPage : ContentPage
    {
       

        public MainPage()
        {
            InitializeComponent();
        }


        private void OnQuitButtonClicked(object sender, EventArgs e)
        {
            Application.Current.Quit();
        }
        private void OnLoginClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DawrfWorkShopIdle.Veiw.SignIn());
        }

        private void OnRegisterButtonClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DawrfWorkShopIdle.Veiw.Register());
        }
    }

}
