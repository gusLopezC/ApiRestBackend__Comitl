using DAL.RestFull;
using Monitoreo.COMMON.Entidades;
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

namespace AdministracionDeDatos
{
    /// <summary>
    /// Lógica de interacción para LecturasWindow.xaml
    /// </summary>
    public partial class LecturasWindow : Window
    {
        private bool nuevo;
        GenericRepository<Lectura> repository;
        public LecturasWindow()
        {
            InitializeComponent();
            repository = new GenericRepository<Lectura>("api/lecturas/");
            nuevo = false;
        }
        private void btnObtener_Click(object sender, RoutedEventArgs e)
        {
            dtgLecturas.ItemsSource = repository.Read;
        }
        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }

       

    }
}
