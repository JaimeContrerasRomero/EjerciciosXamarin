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
	public partial class DolarPeso : ContentPage
	{
		public DolarPeso ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            double ValorDolar = 19.53;
            double CantidadDolar = double.Parse(this.txtValor.Text);
            double ValorPesos = CantidadDolar * ValorDolar;
            DisplayAlert("Conversion", ValorPesos+  " Pesos", "OK");
        }
    }
}