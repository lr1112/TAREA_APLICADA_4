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
    /// Interaction logic for Capi9Ejercicio3.xaml
    /// </summary>
    public partial class Capi9Ejercicio3 : Window
    {
        public Capi9Ejercicio3()
        {
            InitializeComponent();
        }

        private void almacenarInformacion_Click(object sender, RoutedEventArgs e)
        {
            Dueño dueño;
            dueño.nombre = nombreTextBox.Text;
            dueño.direccion = direccionTextBox.Text;
            dueño.edad = int.Parse(edadTextBox.Text);
            dueño.mascota.nombreM = nombreMTextBox.Text;
            dueño.mascota.tipo = tipoMTextBox.Text;
            dueño.mascota.raza = razaMTextBox.Text;

            if (nombreTextBox != null && nombreTextBox != null)
            {
                MessageBox.Show("Su informacion fue almacenada ");
            }
            else
            {
                MessageBox.Show("La informacion no fue almacenada");
            }
        }

        public struct Dueño
        {
            public int edad;
            public Mascota mascota;
            public string nombre;
            public string direccion;
            
        }

        public struct Mascota
        {
            public string nombreM;
            public string tipo;
            public string raza;

            public Mascota(string nombrem, string tipoM, string razaM)
            {
                nombreM = nombrem;
                tipo = tipoM;
                raza = razaM;
            }
        }
    }
}
