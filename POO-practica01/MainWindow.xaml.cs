using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POO_practica01
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void BtnSuma_Click(object sender, RoutedEventArgs e)
        {
            ClOperaciones op = new ClOperaciones();
            // op = new ClOperaciones(decimal.Parse(TextBoxValor1.Text), decimal.Parse(TextBoxValor2.Text));
            //TxtBoxResult.Text = op.suma().ToString();

            op.Val1 = decimal.Parse(TextBoxValor1.Text);
            op.Val2 = decimal.Parse(TextBoxValor2.Text);
            TxtBoxResult.Text = op.suma().ToString();

        }

        private void BtnResta_Click(object sender, RoutedEventArgs e)
        {
            /*ClOperaciones op = new ClOperaciones(decimal.Parse(TextBoxValor1.Text), decimal.Parse(TextBoxValor2.Text));
            TxtBoxResult.Text = op.resta().ToString();*/
            ClOperaciones op = new ClOperaciones();
            op.Val1 = decimal.Parse(TextBoxValor1.Text);
            op.Val2 = decimal.Parse(TextBoxValor2.Text);
            TxtBoxResult.Text = op.resta().ToString();
        }

        private void BtnMulti_Click(object sender, RoutedEventArgs e)
        {
            /*ClOperaciones op = new ClOperaciones(decimal.Parse(TextBoxValor1.Text), decimal.Parse(TextBoxValor2.Text));
            TxtBoxResult.Text = op.multi().ToString();*/
            ClOperaciones op = new ClOperaciones();
            op.Val1 = decimal.Parse(TextBoxValor1.Text);
            op.Val2 = decimal.Parse(TextBoxValor2.Text);
            TxtBoxResult.Text = op.multi().ToString();
        }

        private void BtnDivision_Click(object sender, RoutedEventArgs e)
        {
            /*ClOperaciones op = new ClOperaciones(decimal.Parse(TextBoxValor1.Text), decimal.Parse(TextBoxValor2.Text));
            TxtBoxResult.Text = op.division().ToString();*/
            ClOperaciones op = new ClOperaciones();
            op.Val1 = decimal.Parse(TextBoxValor1.Text);
            op.Val2 = decimal.Parse(TextBoxValor2.Text);
            TxtBoxResult.Text = op.division().ToString();
        }
    }
}
