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
    /// Interaction logic for DeleteTest.xaml
    /// </summary>
    public partial class DeleteTest : Window
    {
        BE.Test test;
        BL.IBL bl;
        public DeleteTest()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            test = new BE.Test();
            TestIDComboBox.ItemsSource = from item in bl.getAllTest()
                                            select item.TestID;
            this.DataContext = test;
        }
            private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BE.Test br = new BE.Test();
                br = bl.getAllTest().FirstOrDefault(b => b.TestID == test.TestID);
                if (br == null)
                    throw new Exception("the tester dosn't exist");
                else bl.deleteTester(br.TesterID);
                MessageBox.Show("the trainee \"" + test.TestID + "\" Deleted from the system", "Deleted successfully!");
                this.DataContext = test;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
