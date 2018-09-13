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

namespace Herencia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Esta lista almacenará todos los animales de manera dinámica
            List<Animal> animales = new List<Animal>();

            Ave tucan = new Ave();
            tucan.Nombre = "John";

            Mamifero tigre = new Mamifero();
            tigre.Nombre = "Toño";

            Reptil lagartija = new Reptil();
            lagartija.Nombre = "Godzilla";

            Pez koi = new Pez();
            koi.Nombre = "Nemo";

            animales.Add(tucan);
            animales.Add(tigre);
            animales.Add(lagartija);
            animales.Add(koi);

            imprimir(tucan.ponerHuevo());
            imprimir(((Reptil)lagartija).cambiarPiel());

            /*  Esto se utilizó antes de agregar la lista y el foreach
            stackRegistro.Children.Add(
                new TextBlock
                {
                    Text = "Yo soy un tucan" + " y " + tucan.desplazar()
                }
            );

            stackRegistro.Children.Add(
                new TextBlock
                {
                    Text = "Yo soy un tigre" + " y " + tigre.desplazar()
                }
            );
            */

            foreach (Animal animal in animales)
            {
                stackRegistro.Children.Add(
                    new TextBlock
                    {
                        Text = animal.desplazar()
                    }
                );
            }
        }

        public void imprimir(string texto)
        {
            stackRegistro.Children.Add
            (
                new TextBlock
                {
                    Text = texto
                }
            );
        }
    }
}
