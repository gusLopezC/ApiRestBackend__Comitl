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
using System.Windows.Shapes;

namespace AdministracionDeDatos
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool nuevo;
        GenericRepository<Usuario> repository;
        public MainWindow()
        {
            InitializeComponent();
            repository = new GenericRepository<Usuario>("api/usuarios/");
            nuevo = false;
        }

        private void btnObtener_Click(object sender, RoutedEventArgs e)
        {
            dtgUsuarios.ItemsSource = repository.Read;
        }

        private void btnNuevo_Click(object sender, RoutedEventArgs e)
        {
            nuevo = true;
            txbApellidos.Clear();
            txbEmail.Clear();
            txbNombre.Clear();
            pswPassword.Clear();
            txbdireccion.Clear();
            txbPoblacion.Clear();
            txbTelefono.Clear();
        }

        private void btnEditar_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = (Usuario)dtgUsuarios.SelectedItem;
            if (u != null)
            {
                nuevo = false;
                txbApellidos.Text = u.Apellidos;
                txbEmail.Text = u.Email;
                txbNombre.Text = u.Nombre;
                txbdireccion.Text = u.direccion;
                txbPoblacion.Text = u.poblacion;
                txbTelefono.Text = u.telefono;
                pswPassword.Password = u.Password;
                txbNombre.Tag = u.ID;
            }
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (nuevo)
            {
                Usuario u = new Usuario()
                {
                    Apellidos = txbApellidos.Text,
                    Email = txbEmail.Text,
                    Nombre = txbNombre.Text,
                    Password = pswPassword.Password,
                    direccion = txbdireccion.Text,
                    poblacion = txbPoblacion.Text,
                    telefono = txbTelefono.Text

                };
                if (repository.Create(u) != null)
                {
                    MessageBox.Show("Dato guardado", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                //editar
                Usuario u = dtgUsuarios.SelectedItem as Usuario;
                u.Apellidos = txbApellidos.Text;
                u.Email = txbEmail.Text;
                u.Nombre = txbNombre.Text;
                u.Password = pswPassword.Password;
                u.direccion = txbdireccion.Text;
                u.poblacion = txbPoblacion.Text;
                u.telefono = txbTelefono.Text;

                if (repository.Update(u) != null)
                {
                    MessageBox.Show("Dato Guardado", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al guardar", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        private void btnEliminar_Click(object sender, RoutedEventArgs e)
        {
            Usuario u = dtgUsuarios.SelectedItem as Usuario;
            if (u != null)
            {
                if (repository.Delete(u))
                {
                    MessageBox.Show("Dato Eliminado", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Error al eliminar", "Usuarios", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }
    }
}
