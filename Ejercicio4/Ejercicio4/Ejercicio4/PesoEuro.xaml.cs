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
	public partial class PesoEuro : ContentPage
	{
		public PesoEuro ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double ValorEuro = 22.12;
            double CantidadPesos = double.Parse(this.txtValor.Text);
            double CantidadEuro = CantidadPesos / ValorEuro;
            DisplayAlert("Conversión", CantidadEuro + " Euros", "Ok");
        }
    }
}