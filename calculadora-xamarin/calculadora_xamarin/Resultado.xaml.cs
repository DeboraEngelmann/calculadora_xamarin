using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace calculadora_xamarin
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class Resultado : Page
    {
        public Resultado(string nome, Double val1, Double val2)
        {
            this.InitializeComponent();
            pessoa.Text = nome + " Resultado: ";
            soma.Text = "Soma: " + (val1 + val2);
            subtracao.Text = "Subtração: " + (val1 - val2);
            multiplicacao.Text = "Multiplicação: " + (val1 * val2);
            if (val2 > 0)
            {
                divisao.Text = "Divisão: " + (val1 / val2);
            }
           
        }

    }
}
