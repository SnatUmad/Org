using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using OrgWPF.BusinessLayer.Models;

namespace OrgWPF
{
    /// <summary>
    /// Interaction logic for AddPayment.xaml
    /// </summary>
    public partial class EditWindowPayment : Window
    {
        public EditWindowPayment()
        {
            InitializeComponent();
        }
        PaymentViewModel payment;        
        public EditWindowPayment(PaymentViewModel payment) : this()
        {
            this.payment = payment;
            grid.DataContext = payment;
        }
        private void BtnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
