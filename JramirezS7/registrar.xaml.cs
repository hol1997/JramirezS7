using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace JramirezS7
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class registrar : ContentPage
    {
       private SQLiteAsyncConnection _connection;
        public registrar()
        {
            InitializeComponent();
            _connection = DependencyService.Get<SQLiteAsyncConnection>();
        }

        private void btnagregar_Clicked(object sender, EventArgs e)
        {
            var datosregistro = new Estudiante { nombre= nombre.Text, usuario= usuario.Text, contresena= contrasenia.Text };
            _connection.InsertAsync(datosregistro);
            limpiarfornulario();
        }
        void limpiarfornulario()
        {
            nombre.Text = "";
            usuario.Text = "";
            contrasenia.Text = "";
            DisplayAlert("Alerta", "Se agrego correctamen", "OK");
        }
    }
}