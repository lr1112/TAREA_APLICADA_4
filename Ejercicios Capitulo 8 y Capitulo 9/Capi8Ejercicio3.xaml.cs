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
    /// Interaction logic for Capi8Ejercicio3.xaml
    /// </summary>
    public partial class Capi8Ejercicio3 : Window
    {
        public Capi8Ejercicio3()
        {
            InitializeComponent();
        }

        private void CalcularHoraButton_Click(object sender, RoutedEventArgs e)
        {
            DateTime date = DateTime.Now;
            HoraTextBox.Text = date.ToString();
        }
    }
}
