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

namespace Vampire_Blood
{
    /// <summary>
    /// Lógica de interacción para Login.xaml
    /// </summary>
    public partial class Login : Window
    {

        public Login()
        {
            InitializeComponent();
            Window_Actions();
        }


        private void Window_Actions()
        {
            btnMinimeze.Click += (sender, e) => { WindowState = WindowState.Minimized; };
            btnClose.Click += (sender, e) => {
                Application.Current.MainWindow.Visibility = Visibility.Visible;
                Close();
            };
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            if(btn.Name == "btnCancelar")
            {
                Application.Current.MainWindow.Visibility = Visibility.Visible;
                Close();
            }
            else
            {
                if (txtFirstName.Text.Equals("") || txtPassword.Text.Equals(""))
                {
                    MessageBox.Show("Necesitas cubrir los dos campos");
                }
                else
                {
                    IniciarSesion();
                }
            }
        }

        private void IniciarSesion()
        {
            MessageBox.Show("name: "+ txtFirstName.Text+" pass: "+txtPassword.Text);

        }

    }
}
