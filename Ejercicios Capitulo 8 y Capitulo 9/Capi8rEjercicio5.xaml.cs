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
using System.Windows.Shapes;

namespace Tarea4Aplicada.Ejercicios_Capitulo_8_y_Capitulo_9
{
    /// <summary>
    /// Interaction logic for Capi8rEjercicio5.xaml
    /// </summary>
    public partial class Capi8rEjercicio5 : Window
    {
        public Capi8rEjercicio5()
        {
            InitializeComponent();
        }

        private void CadenasButton_Click(object sender, RoutedEventArgs e)
        {
            int comparacion;
            string cadena1, cadena2;
            cadena1 = Cadena1TextBox.Text;
            cadena2 = Cadena2TextBox.Text;

            comparacion = cadena1.CompareTo(cadena2);
            if (comparacion == 0)
            {
                MessageBox.Show("Ambas cadenas son iguales");
            }
            else
            {
                if (comparacion < 0)
                {
                    MessageBox.Show(cadena1 + " \n" + cadena2);
                }
                else
                {
                    MessageBox.Show(cadena2 + "\n" + cadena1);
                }
            }
        }
    }
}
