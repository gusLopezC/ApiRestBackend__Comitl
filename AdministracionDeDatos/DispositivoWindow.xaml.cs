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
using System.Windows.Shapes;

namespace AdministracionDeDatos
{
    /// <summary>
    /// Lógica de interacción para DispositivoWindow.xaml
    /// </summary>
    public partial class DispositivoWindow : Window
    {
        private bool nuevo;
        GenericRepository<Dispositivo> repository;
        public DispositivoWindow()
        {
            InitializeComponent();
            repository = new GenericRepository<Dispositivo>("api/dispositivos/");
            nuevo = false;
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

        private void btnObtener_Click(object sender, RoutedEventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
