using CadastroEventoMauiApp.Views;

namespace CadastroEventoMauiApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new CadastroEventoPage());
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 800;


            return window;
        }
    }
}
