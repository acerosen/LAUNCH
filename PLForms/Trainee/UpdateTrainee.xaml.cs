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
using BE;
using BL;

namespace PLForms
{
    /// <summary>
    /// Interaction logic for UpdateBranch.xaml
    /// </summary>
    public partial class UpdateTrainee : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public UpdateTrainee()
        {
            InitializeComponent();
            trainee = new BE.Trainee();
            this.DataContext = trainee;
            bl = BL.FactoryBL.getBL();
            IDComboBox.ItemsSource = from item in bl.getAllTrainee()
                                     select item.branchNumber;
            Gendr.ItemsSource = Enum.GetValues(typeof(BE.Gender));
            GearType.ItemsSource = Enum.GetValues(typeof(BE.GearType));
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.updateTrainee(trainee);
                trainee = new BE.Trainee();
                MessageBox.Show("the trainee " + trainee.FirstName + " update ", "");
                this.DataContext = trainee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            trainee = bl.getAllTrainee(b => b.branchNumber == trainee.branchNumber).FirstOrDefault();
            this.DataContext = trainee;
        }
    }
}
