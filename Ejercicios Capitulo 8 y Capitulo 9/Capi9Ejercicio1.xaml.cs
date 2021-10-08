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
    /// Interaction logic for Capi9Ejercicio1.xaml
    /// </summary>
    public partial class Capi9Ejercicio1 : Window
    {
        public Capi9Ejercicio1()
        {
            InitializeComponent();
        }

        public struct Productos
        {
            public double precio;
            public string Nombre_producto;
            public int Cantidad;

            public Productos(string nombre, int cant, double preci)
            {
                Nombre_producto = nombre;
                Cantidad = cant;
                precio = preci;
            }
        }

        private void AceptarButton_Click(object sender, RoutedEventArgs e)
        {
            string nombre = ProductoTextBox.Text;
            int cant = Convert.ToInt32(CantidadTextBox.Text);
            double preci = Convert.ToDouble(PrecioTextBox.Text);

            Productos product = new Productos(nombre, cant, preci);

            MessageBox.Show("Guardado correctamente");
        }

        private void LimpiarButton_Click(object sender, RoutedEventArgs e)
        {
            ProductoTextBox.Clear();
            PrecioTextBox.Clear();
            CantidadTextBox.Clear();
        }
    }
}

       
