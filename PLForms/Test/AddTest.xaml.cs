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
    /// Interaction logic for AddTest.xaml
    /// </summary>
    public partial class AddTest : Window
    {
        BE.Test test;
        BL.IBL bl;
        static public int oN = 10000;
        public AddTest()
        {
            InitializeComponent();
            test = new Test();
            this.DataContext = test;
            bl = BL.FactoryBL.getBL();
            TraineeIDcomboBox.ItemsSource = from item in bl.getAllTrainee()
                                            select item.branchNumber;
            TesterIDcomboBox.ItemsSource = from item in bl.getAllTester()
                                           select item.TesterID;
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ++oN;
                test.TestID = oN;
                bl.addTest(test);
                MessageBox.Show(test.TraineeID + " your Test Added successfully, test number is " + test.TestID, " ");
                test = new BE.Test();
                this.DataContext = test;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
