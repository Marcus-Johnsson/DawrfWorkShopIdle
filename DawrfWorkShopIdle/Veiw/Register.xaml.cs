using System.Threading.Tasks;
using Windows.ApplicationModel.Background;

namespace DawrfWorkShopIdle.Veiw;

public partial class Register : ContentPage
{
	public Register()
	{
		InitializeComponent();
	}

    private void OnCreateAccountClicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new DawrfWorkShopIdle.Veiw.GamePage());
    }

    private void OnCancelClicked(System.Object sender, System.EventArgs e)
    {
         Navigation.PopAsync();
    }
}