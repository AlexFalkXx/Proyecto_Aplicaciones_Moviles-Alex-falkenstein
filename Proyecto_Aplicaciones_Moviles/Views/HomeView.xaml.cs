using Microsoft.Maui.Controls;
using System;

namespace Proyecto_Aplicaciones_Moviles.Views
{
    public partial class HomeView : ContentPage
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private async void OnExitButtonClicked(object sender, EventArgs e)
        {
            bool answer = await DisplayAlert("Salir", "¿Estás seguro que deseas salir?", "Sí", "No");
            if (answer)
            {
                // Cierra la aplicación
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private async void OnAboutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutView());
        }


    }
}
