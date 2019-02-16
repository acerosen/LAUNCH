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
    public partial class DeleteTester : Window
    {
        BE.Tester tester;
        BL.IBL bl;
        public DeleteTester()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            tester = new BE.Tester();
            firstNameComboBox.ItemsSource = from item in bl.getAllTester()
                                            select item.FirstName;
            this.DataContext = tester;
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Tester br = new BE.Tester();
                br = bl.getAllTester().FirstOrDefault(b => b.FirstName == tester.FirstName);
                if (br == null)
                    throw new Exception("the tester dosn't exist");
                else bl.deleteTester(br.TesterID);
                MessageBox.Show("the trainee \"" + tester.FirstName + "\" Deleted from the system", "Deleted successfully!");
                this.DataContext = tester;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
