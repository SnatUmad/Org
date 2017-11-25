using System.Windows;
using OrgWPF.BusinessLayer.Models;

namespace OrgWPF
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class EditWindowOrg : Window
    {
        OrgViewModel org;
        public EditWindowOrg()
        {
            InitializeComponent();
        }
        public EditWindowOrg(OrgViewModel org) : this()
        {
            this.org = org;
            grid.DataContext = org;
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
