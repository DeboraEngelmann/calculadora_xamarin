using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace calculadora_xamarin
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Result : ContentPage
	{
        public Result(string nome, Double val1, Double val2)
        {
            InitializeComponent();
            pessoa.Text = nome + " O resultado foi: ";

            soma.Text = "Soma : " + (val1 + val2);
            subtracao.Text = "Subtração: " + (val1 - val2);
            multiplicacao.Text = "Multiplicação: " + (val1 * val2);
            if (val2 > 0)
            {
                divisao.Text = "Divisão: " + (val1 / val2);
            }
            
        }

    }
}