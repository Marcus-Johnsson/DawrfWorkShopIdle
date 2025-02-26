namespace DawrfWorkShopIdle
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("SignIn", typeof(Veiw.SignIn));

            Routing.RegisterRoute("Register", typeof(Veiw.Register));

            Routing.RegisterRoute("Home", typeof(MainPage));


        }
    }
}
