using Microsoft.Maui.Controls;
using System;

namespace Proyecto_Aplicaciones_Moviles.Views
{
    public partial class LoginView : ContentPage
    {
        public LoginView()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            string username = UsernameEntry.Text;
            string password = PasswordEntry.Text;

            if (username == "alumno" && password == "1234")
            {
                await DisplayAlert("Login", "Inicio de sesi�n exitoso", "OK");
                // Navegar a la siguiente p�gina despu�s del inicio de sesi�n exitoso.
                await Navigation.PushAsync(new HomeView());
            }
            else
            {
                await DisplayAlert("Error", "Nombre o contrase�a incorrectos", "OK");
            }
        }
    }
}
