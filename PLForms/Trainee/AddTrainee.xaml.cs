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
    /// Interaction logic for AddBranch.xaml
    /// </summary>
    public partial class AddTrainee : Window
    {
        BE.Trainee trainee;
        BL.IBL bl;
        public AddTrainee()
        {
            InitializeComponent();

            trainee = new BE.Trainee();
            this.gridAddTrainee.DataContext = trainee;
            bl = BL.FactoryBL.getBL();
            Gender.ItemsSource = Enum.GetValues(typeof(BE.Gender));
            GearType.ItemsSource = Enum.GetValues(typeof(BE.GearType));
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addTrainee(trainee);
                MessageBox.Show("the trainee " + trainee.FirstName + trainee.FamilyName + " was added", "");
                trainee = new BE.Trainee();
                this.gridAddTrainee.DataContext = trainee;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
