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
	public partial class PesoDolar : ContentPage
	{
		public PesoDolar ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double ValorDolar = 19.53;
            double CantidadPesos = double.Parse(this.txtValor.Text);
            double CantidadDolares = CantidadPesos / ValorDolar;
            DisplayAlert("Conversión", CantidadDolares + " Dolares", "Ok");
        }
    }
}