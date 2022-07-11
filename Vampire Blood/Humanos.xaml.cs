using System;
using System.Collections.Generic;
using System.Data;
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
    /// Lógica de interacción para Humanos.xaml
    /// </summary>
    public partial class Humanos : Window
    {

        public Humanos()
        {
            InitializeComponent();
            Window_Actions();

            CreateTable();

        }

        private void CreateTable()
        {
        }

        private void Window_Actions()
        {
            btnMinimeze.Click += (sender, e) => { WindowState = WindowState.Minimized; };
            btnMaximize.Click += (sender, e) => { WindowState = WindowState == WindowState.Maximized ? WindowState.Normal : WindowState.Maximized; };
            btnClose.Click += (sender, e) => { Close(); };
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
                this.DragMove();
        }




    }
}
