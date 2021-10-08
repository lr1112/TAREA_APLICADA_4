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
using Tarea4Aplicada.Ejercicios_Capitulo_8_y_Capitulo_9;

namespace Tarea4Aplicada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Cap8Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            Capi8Ejercicio3 cap83 = new Capi8Ejercicio3();
            cap83.Show();
        }

        private void Cap8Ejercicio5_Click(object sender, RoutedEventArgs e)
        {
            Capi8rEjercicio5 cap85 = new Capi8rEjercicio5();
            cap85.Show();
        }

        private void Cap9Ejercicio1_Click(object sender, RoutedEventArgs e)
        {
            Capi9Ejercicio1 cap91 = new Capi9Ejercicio1();
            cap91.Show();
        }

        private void Cap9Ejercicio3_Click(object sender, RoutedEventArgs e)
        {
            Capi9Ejercicio3 cap93 = new Capi9Ejercicio3();
            cap93.Show();
        }

        private void Cap9Ejercicio4_Click(object sender, RoutedEventArgs e)
        {
            Capi9Ejercicio4 cap94 = new Capi9Ejercicio4();
            cap94.Show();
        }
    }
}
