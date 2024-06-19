using Microsoft.Maui.Controls;
using BLOGSOCIALUDLA.Models;
using System;
using BLOGSOCIALUDLA.Data;
//using BLOGSOCIALUDLA.Models.BLOGSOCIALUDLA.Models;

namespace BLOGSOCIALUDLA.Views
{
    public partial class RegistroUsuario : ContentPage
    {
        User _user;
        public RegistroUsuario()
        {
            InitializeComponent();
            _user = new User();
            this.BindingContext = _user;    
    
        }

        private async void ClickRegistrarse(object sender, EventArgs e)
        {
            
            if(string.IsNullOrWhiteSpace(_user.Nombres)&&string.IsNullOrWhiteSpace(_user.Apellidos)
                && string.IsNullOrWhiteSpace(_user.NumeroTelefono) && string.IsNullOrWhiteSpace(_user.Username)
               && string.IsNullOrWhiteSpace(_user.Password)
                ){
                await DisplayAlert("Alerta", "LLena todas las celdas", "Ok");
                return;

            }

            var registro = await App.Datos.UserDataTable.GuardarUser(_user);
            if (registro > 0)
            {
                Application.Current.MainPage.DisplayAlert("Registro Realizado", "Tu usuario ha sido registrado exitosamente. Ahora puede iniciar sesión.", "OK");
                Application.Current.MainPage = new NavigationPage(new InicioSesion());
            }

            
          
           
        }

        private void ClickInicioSesionRegistro(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }
    }
}
