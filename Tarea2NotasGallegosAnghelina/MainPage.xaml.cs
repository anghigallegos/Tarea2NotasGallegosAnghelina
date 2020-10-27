using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Tarea2NotasGallegosAnghelina
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btnSaludo_Clicked(object sender, EventArgs e)
        {
            string texto = txtNombre.Text;
            string mensaje = "Hola " + texto;
            DisplayAlert("Mensaje de bienvenida", mensaje, "Gracias");
        }
    }
}
