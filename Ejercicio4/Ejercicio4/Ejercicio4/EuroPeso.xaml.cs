using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Ejercicio4
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EuroPeso : ContentPage
	{
		public EuroPeso ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double ValorEuro = 22.12;
            double CantidadEuro = double.Parse(this.txtValor.Text);
            double CantidadPeso = ValorEuro * CantidadEuro;
            DisplayAlert("Convesión", CantidadPeso + " Pesos", "Ok");
        }
    }
}