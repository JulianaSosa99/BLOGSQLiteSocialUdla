using BLOGSOCIALUDLA.Data;
using BLOGSOCIALUDLA.Models;
using BLOGSOCIALUDLA.Views;
using System.Security.Cryptography.X509Certificates;

namespace BLOGSOCIALUDLA
{
    public partial class App : Application
    {


        static SQLiteData _datos;
        public static SQLiteData Datos
        {
            get
            {
               if(_datos == null)
                {

                    _datos = new SQLiteData(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Datos.db"));

                }
               return _datos;   
            }
            
        }
        public static User user { get; set; }

        public App()
        {
            InitializeComponent();
             
            var navPage = new NavigationPage(new InicioSesion());
            navPage.Background = Colors.DarkRed;
            navPage.BarTextColor = Colors.DarkRed;
 
            MainPage = new AppShell();


           
        }
    }
}
