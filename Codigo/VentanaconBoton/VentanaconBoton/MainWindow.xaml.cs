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

namespace VentanaconBoton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool azul=true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void miBoton_Click(object sender, RoutedEventArgs e)
        {
            if(azul)
            {
                miBoton.Background = Brushes.Aqua;
            }
            else
            {
                miBoton.Background = Brushes.Blue;
            }
            azul = !azul;
        }
    }
}
