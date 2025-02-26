namespace DawrfWorkShopIdle
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
           var MainPage = new NavigationPage(new MainPage());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            return new Window(new AppShell());
        }
    }
}