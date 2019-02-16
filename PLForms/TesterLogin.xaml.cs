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

namespace PLForms
{
    /// <summary>
    /// Interaction logic for testerlogin.xaml
    /// </summary>
    public partial class testerlogin : Window
    {
        public testerlogin()
        {
            InitializeComponent();
        }
        private void AddTester_Click(object sender, RoutedEventArgs e)
        {
            new AddTester().ShowDialog();
        }
        private void UpdateTester_Click(object sender, RoutedEventArgs e)
        {
            new UpdateTester().ShowDialog();
        }
        private void DeleteTester_Click(object sender, RoutedEventArgs e)
        {
            new DeleteTester().ShowDialog();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
