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
    /// Interaction logic for BranchOption.xaml
    /// </summary>
    public partial class adminlogin : Window
    {
        public adminlogin()
        {
            InitializeComponent();
        }
        private void AddTrainee_Click(object sender, RoutedEventArgs e)
        {
            new AddTrainee().ShowDialog();
        }
        private void UpdateTrainee_Click(object sender, RoutedEventArgs e)
        {
            new UpdateTrainee().ShowDialog();
        }
        private void DeleteTrainee_Click(object sender, RoutedEventArgs e)
        {
            new DeleteTrainee().ShowDialog();
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
        private void AddTest_Click(object sender, RoutedEventArgs e)
        {
            new AddTest().ShowDialog();
        }
        private void UpdateTest_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        private void DeleteTest_Click(object sender, RoutedEventArgs e)
        {
            new DeleteTest().ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            new Window2().ShowDialog();
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            new Window3().ShowDialog();
        }
    }
}
