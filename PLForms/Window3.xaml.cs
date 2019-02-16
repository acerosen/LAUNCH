using BE;
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
using BL;

namespace PLForms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window3 : Window
    {
        IEnumerable<Test> tests;
        BL.IBL bl;
        public Window3()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            tests = from item in bl.getAllTest()
                      select item;
            DataContext = tests;
        }
    }
}
