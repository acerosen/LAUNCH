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
    /// Interaction logic for Deletetrainee.xaml
    /// </summary>
    public partial class DeleteTrainee : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public DeleteTrainee()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            trainee = new BE.Trainee();
            firstNameComboBox.ItemsSource = from item in bl.getAllTrainee()
                                             select item.FirstName;
            this.DataContext = trainee;
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Trainee br = new BE.Trainee();
                br = bl.getAllTrainee().FirstOrDefault(b => b.FirstName == trainee.FirstName);
                if (br == null)
                    throw new Exception("the trainee dosn't exist");
                else bl.deleteTrainee(br.branchNumber);
                MessageBox.Show("the trainee \"" + trainee.FirstName + "\" Deleted from the system", "Deleted successfully!");
                this.DataContext = trainee;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
