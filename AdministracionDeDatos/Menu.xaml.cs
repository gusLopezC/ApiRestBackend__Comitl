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

namespace AdministracionDeDatos
{
    /// <summary>
    /// Lógica de interacción para Menu.xaml
    /// </summary>
    public partial class Menu : Window
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnUsuarios_Clic(object sender, RoutedEventArgs e)
        {
            MainWindow v = new MainWindow();
            v.Show();
        }
        private void btnLecturas_Clic(object sender, RoutedEventArgs e)
        {
            LecturasWindow v = new LecturasWindow();
            v.Show();
        }
        private void btnTipoLectura_Clic(object sender, RoutedEventArgs e)
        {
            TipoLecturaWindow v = new TipoLecturaWindow();
            v.Show();
        }
        private void btnDispositivo_Clic(object sender, RoutedEventArgs e)
        {
            DispositivoWindow v = new DispositivoWindow();
            v.Show();
        }
    }
}
