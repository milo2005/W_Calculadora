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
        const int SUMA = 1;
        const int RESTA = 2;
        const int MUL = 3;
        const int DIV = 4;

        string num1;
        string num2;

        int op;

        public MainPage()
        {
            this.InitializeComponent();
            num1 = "";
            num2 = "";
            op = 0;

            
        }

        private void onClick(object sender, RoutedEventArgs e)
        {

            var btnSender = sender as Button;

            switch (btnSender.Name) {

                case "btnUno":
                    insertNumber("1");
                    break;

                case "btnDos":
                    insertNumber("2");
                    break;

                case "btnTres":
                    insertNumber("3");
                    break;

                case "btnCuatro":
                    insertNumber("4");
                    break;

                case "btnCinco":
                    insertNumber("5");
                    break;

                case "btnSeis":
                    insertNumber("6");
                    break;

                case "btnSiete":
                    insertNumber("7");
                    break;

                case "btnOcho":
                    insertNumber("8");
                    break;

                case "btnNueve":
                    insertNumber("9");
                    break;

                case "btnCero":
                    insertNumber("0");
                    break;

                case "btnMas":
                    setOperation(SUMA);
                    break;

                case "btnMenos":
                    setOperation(RESTA);
                    break;

                case "btnMul":
                    setOperation(MUL);
                    break;

                case "btnDiv":
                    setOperation(DIV);
                    break;

                case "btnReset":
                    resetData();
                    break;

                case "btnIgual":
                    makeOperation();
                    break;


            }


        }

        public void resetData() {
            num1 = "";
            num2 = "";
            op = 0;
            txt.Text = "";
        }

        public void insertNumber(string n) {
            if (op == 0)
            {
                num1 = num1 + n;
                txt.Text = num1;
            }
            else {
                num2 = num2 + n;
                txt.Text = num2;
            }

        }

        public void setOperation(int operation) {
            op = operation;
            txt.Text = " ";
        }

        public void makeOperation() {
            int rta = 0;
            int n1 = Convert.ToInt32(num1);
            int n2 = Convert.ToInt32(num2);

            switch (op) {
                case SUMA:
                    rta = n1 + n2;
                    break;
                case RESTA:
                    rta = n1 - n2;
                    break;
                case MUL:
                    rta = n1 * n2;
                    break;
                case DIV:
                    rta = n1 / n2;
                    break;
            }
            txt.Text = "" + rta;

        }


    }
}
