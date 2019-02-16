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
    /// Interaction logic for EditTester.xaml
    /// </summary>
    public partial class AddTester : Window
    {
        BE.Tester tester;
        BL.IBL bl;
        public AddTester()
        {
            InitializeComponent();

            tester = new BE.Tester();
            this.gridAddTester.DataContext = tester;
            bl = BL.FactoryBL.getBL();
            GenderComboBox.ItemsSource = Enum.GetValues(typeof(BE.Gender));
        }
        private void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addTester(tester);
                MessageBox.Show("the tester " + tester.FirstName + " was added", "");
                tester = new BE.Tester();
                this.gridAddTester.DataContext = tester;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}