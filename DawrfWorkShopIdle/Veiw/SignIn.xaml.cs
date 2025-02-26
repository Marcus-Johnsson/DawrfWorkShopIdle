using System.Threading.Tasks;

namespace DawrfWorkShopIdle.Veiw;

public partial class SignIn : ContentPage
{
	public SignIn()
	{
		InitializeComponent();
	}


  

    private void OnLoginClicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new DawrfWorkShopIdle.Veiw.GamePage());
    }

    private void OnCancelButtonClicked(System.Object sender, System.EventArgs e)
    {
         Navigation.PopAsync();
    }
}