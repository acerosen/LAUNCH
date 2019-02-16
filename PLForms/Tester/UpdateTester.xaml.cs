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
    public partial class UpdateTester : Window
    {
        BE.Tester tester;
        BL.IBL bl;
        public UpdateTester()
        {
            InitializeComponent();
            tester = new BE.Tester();
            this.DataContext = tester;
            bl = BL.FactoryBL.getBL();
            IDComboBox.ItemsSource = from item in bl.getAllTester()
                                     select item.TesterID;
            //Gender.ItemsSource = Enum.GetValues(typeof(BE.Gender));
        }
        private void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.updateTester(tester);
                tester = new BE.Tester();
                MessageBox.Show("the tester " + tester.FirstName + " update ", "");
                this.DataContext = tester;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void IDComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            tester = bl.getAllTester(b => b.TesterID == tester.TesterID).FirstOrDefault();
            this.DataContext = tester;
        }
    }
}
