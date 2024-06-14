using Microsoft.Maui.Controls;
using System;

namespace Proyecto_Aplicaciones_Moviles.Views
{
    public partial class AboutView : ContentPage
    {
        public AboutView()
        {
            InitializeComponent();
        }

        private async void OnBackButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync(); // Regresa a la p�gina anterior
        }

        private async void OnMailButtonClicked(object sender, EventArgs e)
        {
            // L�gica para el bot�n de Mail
            await DisplayAlert("Mail", "Enviar correo a Alex, Daniel Falkenstein", "OK");
        }

        private async void OnCallButtonClicked(object sender, EventArgs e)
        {
            // L�gica para el bot�n de Llamada
            await DisplayAlert("Llamada", "Llamar a Alex, Daniel Falkenstein", "OK");
        }
    }
}
