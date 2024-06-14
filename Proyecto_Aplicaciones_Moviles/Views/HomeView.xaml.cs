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
            bool answer = await DisplayAlert("Salir", "�Est�s seguro que deseas salir?", "S�", "No");
            if (answer)
            {
                // Cierra la aplicaci�n
                System.Diagnostics.Process.GetCurrentProcess().Kill();
            }
        }

        private async void OnAboutButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AboutView());
        }


    }
}
