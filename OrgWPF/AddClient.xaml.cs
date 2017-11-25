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
    /// Interaction logic for AddClient.xaml
    /// </summary>
    public partial class EditWindowClient : Window
    {
        ClientViewModel client;
        public EditWindowClient()
        {
            InitializeComponent();
        }
        public EditWindowClient(ClientViewModel client) : this()
        {
            this.client = client;
            grid.DataContext = client;
        }
        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void BtnCancel_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
