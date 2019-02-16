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
    /// Interaction logic for traineelogin.xaml
    /// </summary>
    public partial class traineelogin : Window
    {
        public traineelogin()
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
        private void AddTest_Click(object sender, RoutedEventArgs e)
        {
            new AddTest().ShowDialog();
        }
        private void UpdateTest_Click(object sender, RoutedEventArgs e)
        {
            new AddTest().ShowDialog();
        }
        private void DeleteTest_Click(object sender, RoutedEventArgs e)
        {
            new DeleteTest().ShowDialog();
        }
        private void Exit_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Window3().ShowDialog();
        }

        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            new Window1().ShowDialog();
        }
    }
}
// try running it