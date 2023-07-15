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
    public partial class ConsultaRegistra : ContentPage
    {
        public ConsultaRegistra()
        {
            InitializeComponent();
            
        }

        private void ListaEstudiante_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

            var objetoEstudiante =(Estudiante)e.SelectedItem;
            Navigation.PushAsync(new Elemento(objetoEstudiante));
        }
    }
}