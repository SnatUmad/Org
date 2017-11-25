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
using OrgWPF.BusinessLayer.Models;

namespace OrgWPF
{
    /// <summary>
    /// Interaction logic for AddOrder.xaml
    /// </summary>
    public partial class EditWindowOrder : Window
    {
        OrderViewModel order;
        public EditWindowOrder()
        {
            InitializeComponent();
        }
        public EditWindowOrder(OrderViewModel order) : this()
        {
            this.order = order;
            grid.DataContext = order;
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
