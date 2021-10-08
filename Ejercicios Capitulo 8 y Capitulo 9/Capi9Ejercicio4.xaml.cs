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
    /// Interaction logic for Capi9Ejercicio4.xaml
    /// </summary>
    public partial class Capi9Ejercicio4 : Window
    {
        public Capi9Ejercicio4()
        {
            InitializeComponent();
            neumaticosComboBox.ItemsSource = Enum.GetValues(typeof(Neumaticos));
        }

      

        private void ConfirmarButton_Click(object sender, RoutedEventArgs e)
        {

            
            MessageBox.Show("!Confirmado!");
        }
        public enum Neumaticos
        {
            Neumatico_Radial,
            Neumatico_Diagonal,
            Neumatico_de_Verano,
            Neumatico_de_Invierno,
            Neumatico_AllSeasons,
            Neumatico_Asimetrico,
            Neumatico_Direccional,
            Neumatico_Ecologicos
        }
    }
}
