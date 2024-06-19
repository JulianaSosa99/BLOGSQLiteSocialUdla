using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System;
using System.Linq;
using BLOGSOCIALUDLA.Data;
//using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class InicioSesion : ContentPage
    {
        public InicioSesion()
        {
            InitializeComponent();
        }

 
        private async void ClickIngreso(object sender, EventArgs e)
        {
            string username = usernameEntry.Text;
            string password = passwordEntry.Text;

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                errorMessage.Text = "Por favor, ingrese nombre de usuario y contrase�a.";
                errorMessage.IsVisible = true;
                return;
            }
            var user = await App.Datos.UserDataTable.ObtenerUser(username, password);   
           // var user = UserData.Users.FirstOrDefault(u => u.Username == username && u.Password == password);
            if (user != null)

            {
                UserData.CurrentUser = user;
                App.user=user;
                Application.Current.MainPage = new NavigationPage(new GaleriaServicios());
            }
            else
            {
                errorMessage.Text = "Nombre de usuario o contrase�a incorrectos.";
                errorMessage.IsVisible = true;
            }
        }


        private async void ClickRegistroInicio(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new RegistroUsuario());

        }
    }
}
