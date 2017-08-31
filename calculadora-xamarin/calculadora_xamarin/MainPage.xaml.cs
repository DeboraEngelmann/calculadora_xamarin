using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace calculadora_xamarin
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
            
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            if ((valor1.Text != null && valor2.Text != null) && (!(valor1.Text.Equals("")) && !(valor2.Text.Equals(""))))
            {
                var modalPage1 = new Result(nome.Text, Double.Parse(valor1.Text), Double.Parse(valor2.Text));
                Navigation.PushModalAsync(modalPage1, true);
            }
            else
            {
                DisplayAlert("Alerta", "Valores Inválidos!", "OK");
            }

        }

    }
}
