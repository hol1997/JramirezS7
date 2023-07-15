using SQLite;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JramirezS7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class login : ContentPage
    {
        private SQLiteConnection _connection;
        public login()
        {
            InitializeComponent();
            _connection = DependencyService.Get<datebase>().GetConnection();
        }

        private void btnlogin_Clicked(object sender, EventArgs e)
        {
            try
            {
                var databasePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "uisrael.db3");
                var db = new SQLiteConnection(databasePath);

                db.CreateTable<string>();
                IEnumerable<Estudiante> resultado = SELECT_WHERE(db, usuario.Text, contra.Text);
                if (resultado.Count() > 0) 
                {
                    Navigation.PushAsync(new ConsultaRegistra());
                }
                else
                {
                    DisplayAlert("Alerta", "Verifique su usuario o contraseña", "OK");
                }

            }
            catch (Exception ex)
            {

                DisplayAlert("Alerta", ex.Message, "Error");
            }

        }

        private async void btnregistrar_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new registrar());

        }
        public static IEnumerable<Estudiante> SELECT_WHERE(SQLiteConnection db, string usuario, string contresena)
        {
            return db.Query<Estudiante>("Select* from Estudiante where usuario = ? amd contresena = ?", usuario, contresena);

        }
    }
}