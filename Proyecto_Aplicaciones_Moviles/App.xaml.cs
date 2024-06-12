using Microsoft.Maui.Controls;
using Proyecto_Aplicaciones_Moviles.Views;

namespace Proyecto_Aplicaciones_Moviles
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginView());
        }
    }
}
