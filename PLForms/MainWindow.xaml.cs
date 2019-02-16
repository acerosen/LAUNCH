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
using BL;
namespace PLForms
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Testerlogin_Click(object sender, RoutedEventArgs e)
        {
            new testerlogin().ShowDialog();
        }
        private void Adminlogin_Click(object sender, RoutedEventArgs e)
        {
            new adminlogin().ShowDialog();
        }
        private void Traineelogin_Click(object sender, RoutedEventArgs e)
        {
            new traineelogin().ShowDialog();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
