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

// La plantilla de elemento Página en blanco está documentada en http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace WCalculadora
{
    /// <summary>
    /// Página vacía que se puede usar de forma independiente o a la que se puede navegar dentro de un objeto Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            
        }

        private void onClick(object sender, RoutedEventArgs e)
        {

            var btnSender = sender as Button;

            switch (btnSender.Name) {

                case "btnUno":

                    break;

                case "btnDos":

                    break;

                case "btnTres":

                    break;

                case "btnCuatro":

                    break;

                case "btnCinco":

                    break;

                case "btnSeis":

                    break;

                case "btnSiete":

                    break;

                case "btnOcho":

                    break;

                case "btnNueve":
                    break;

                case "btnCero":
                    break;

                case "btnSuma":
                    
                    break;

                case "btnResta":
                    break;

                case "btnMul":
                    break;

                case "btnDiv":
                    break;

                case "btnReset":
                    break;

                case "btnIgual":
                    break;


            }


        }
    }
}
