using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Ejercicio3
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            //convertir las variables de string a double
            double n1 = double.Parse(this.txtNumero1.Text);
            double n2 = double.Parse(this.txtNumero2.Text);

            //determinar el valor de la opción que seleccionó el usuario
            int opcion = this.cboOperacion.SelectedIndex;

            //dependiendo la opción, se debe realizar la operación.
            switch (opcion)
            {
                case 0:
                    DisplayAlert("Resultado", "Suma: " + (n1 + n2), "Ok");
                    break;
                case 1:
                    DisplayAlert("Resultado", "Resta: " + (n1 - n2), "Ok");
                    break;
                case 2:
                    DisplayAlert("Resultado", "Multiplicación: " + (n1 * n2), "Ok");
                    break;
                case 3:
                    DisplayAlert("Resultado", "Division: " + (n1 / n2), "Ok");
                    break;
            }
        }
    }
}
