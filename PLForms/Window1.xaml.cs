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

namespace PLForms
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        IEnumerable<Trainee> traineees;
        BL.IBL bl;
        public Window1()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            traineees = from item in bl.getAllTrainee()
                       select item;
            DataContext = traineees;
        }
    }
}
