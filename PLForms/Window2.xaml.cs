﻿using BE;
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
    public partial class Window2 : Window
    {
        IEnumerable<Tester> testers;
        BL.IBL bl;
        public Window2()
        {
            InitializeComponent();
            bl = BL.FactoryBL.getBL();
            testers = from item in bl.getAllTester()
                        select item;
            DataContext = testers;
        }
    }
}
