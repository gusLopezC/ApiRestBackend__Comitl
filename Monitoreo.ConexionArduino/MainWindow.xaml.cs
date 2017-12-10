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
using System.IO.Ports;
using System.Windows.Threading;

namespace Monitoreo.ConexionArduino
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private SerialPort puerto;
        private string cadena;
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();//NoBorrarEstaLinea
            cmbPuerto.ItemsSource = SerialPort.GetPortNames();
            puerto = new SerialPort();
            cadena = "";
            timer = new DispatcherTimer();
            timer.Interval = new TimeSpan(0, 0, 0, 10);
            timer.Tick += Timer_Tick;
            
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            if (cadena != "")
            {
                EscribirEnLog("Puerto", cadena);
            }
        }

        private void EscribirEnLog(string v, string cadena)
        {
            //throw new NotImplementedException();
            txtblog.Text += "[" + v + "]: " + cadena + "\n\r";
            txtblog.ScrollToEnd();        }

        private void chkConectar_Checked(object sender, RoutedEventArgs e)
        {
            puerto = new SerialPort(cmbPuerto.Text);
            puerto.DataReceived += Puerto_DataReceived;
            puerto.Parity = Parity.None;
            puerto.BaudRate = 9600;
            puerto.StopBits = StopBits.One;
            puerto.ReadTimeout = 5000;
            puerto.WriteTimeout = 1000;
            puerto.Handshake = Handshake.None;
            puerto.ReadBufferSize = 64;
            puerto.WriteBufferSize = 64;
            puerto.DtrEnable = true;
            puerto.RtsEnable = true;
            if(!puerto.IsOpen)
            { 
                puerto.Open();
                timer.Start();
            }

        }

        private void Puerto_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //throw new NotImplementedException();
            cadena = puerto.ReadLine();

        }

        private void chkConectar_Unchecked(object sender, RoutedEventArgs e)
        {

        }
    }
}
