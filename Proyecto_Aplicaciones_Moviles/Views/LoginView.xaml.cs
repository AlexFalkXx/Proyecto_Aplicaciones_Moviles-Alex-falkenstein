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
                await DisplayAlert("Login", "Inicio de sesión exitoso", "OK");
                // Navegar a la siguiente página después del inicio de sesión exitoso.
                await Navigation.PushAsync(new HomeView());
            }
            else
            {
                await DisplayAlert("Error", "Nombre o contraseña incorrectos", "OK");
            }
        }
    }
}
