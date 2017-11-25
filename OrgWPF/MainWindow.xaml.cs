using System;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using OrgWPF.BusinessLayer.Interfaces;
using OrgWPF.BusinessLayer.Models;
using OrgWPF.BusinessLayer.Service;

namespace OrgWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<OrgViewModel> orgs;
        ObservableCollection<ClientViewModel> clients;
        ObservableCollection<PaymentViewModel> payments;
        ObservableCollection<OrderViewModel> orders;        
        OrgService orgService;
        ClientService clientService;
        OrderService orderService;
        PaymentService paymentService;
        public MainWindow()
        {
            InitializeComponent();
            orgService = new OrgService("TestDbConnection");
            clientService = new ClientService("TestDbConnection");
            orderService = new OrderService("TestDbConnection");
            paymentService = new PaymentService("TestDbConnection");
            orgs = orgService.GetAll();
            OrgBox.ItemsSource = orgs;
            //ClientBox.DataContext = orgs;            
            //OrderBox.DataContext = orgs;
            //var curorg = (OrgViewModel)OrgBox.SelectedItem;
            //clients = curorg.Clients;
            //ClientBox.ItemsSource = clients;            
            //orders = orderService.GetAll();
            //OrderBox.DataContext = orders;
            //payments = paymentService.GetAll();
            //PaymentGrid.ItemsSource = payments;
        }

        private void AddOrg_Click(object sender, RoutedEventArgs e)
        {
            var orVM = new OrgViewModel();
            EditWindowOrg ew = new EditWindowOrg(orVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                orgService.Create(orVM);
                ew.Close();
                orgs = orgService.GetAll();
                OrgBox.ItemsSource = orgs;
                clients = clientService.GetAll();
                ClientBox.ItemsSource = clients;
                orders = orderService.GetAll();
                OrderBox.ItemsSource = orders;
                payments = paymentService.GetAll();
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void DeleteOrg_Click(object sender, RoutedEventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                OrgViewModel orVM = OrgBox.SelectedItem as OrgViewModel;
                orgService.Delete(orVM.OrgID);
                orgs = orgService.GetAll();
                OrgBox.ItemsSource = orgs;
                clients = clientService.GetAll();
                ClientBox.ItemsSource = clients;
                orders = orderService.GetAll();
                OrderBox.ItemsSource = orders;
                payments = paymentService.GetAll();
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void UpdateOrg_Click(object sender, RoutedEventArgs e)
        {
            OrgViewModel orVM = OrgBox.SelectedItem as OrgViewModel;
            EditWindowOrg ew = new EditWindowOrg(orVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                orgService.Update(orVM);
                ew.Close();
                orgs = orgService.GetAll();
                OrgBox.ItemsSource = orgs;
            }            
        }

        private void AddClient_Click(object sender, RoutedEventArgs e)
        {            
            var clVM = new ClientViewModel();
            EditWindowClient ew = new EditWindowClient(clVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                var org = OrgBox.SelectedItem as OrgViewModel;                
                clientService.AddClientToOrg(org.OrgID, clVM);
                ew.Close();
                //orgs = orgService.GetAll();
                clients = clientService.GetAll();
                orders = orderService.GetAll();
                payments = paymentService.GetAll();
                //OrgBox.ItemsSource = orgs;
                ClientBox.ItemsSource = clients;
                OrderBox.ItemsSource = orders;
                PaymentGrid.ItemsSource = payments;
            }           
        }

        private void DeleteClient_Click(object sender, RoutedEventArgs e)
        {            
            var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {                
                ClientViewModel clVM = ClientBox.SelectedItem as ClientViewModel;
                var org = OrgBox.SelectedItem as OrgViewModel;
                clientService.RemoveClientFromOrg(org.OrgID, clVM);
                //org.Clients.Remove(clVM);
                //clients.Remove(clVM);
                clients = clientService.GetAll();                
                ClientBox.ItemsSource = clients;
                orders = orderService.GetAll();
                OrderBox.ItemsSource = orders;
                payments = paymentService.GetAll();
                PaymentGrid.ItemsSource = payments;
            }            
        }
       
        private void UpdateClient_Click(object sender, RoutedEventArgs e)
        {
            ClientViewModel clVM = ClientBox.SelectedItem as ClientViewModel;
            EditWindowClient ew = new EditWindowClient(clVM);
            var result = ew.ShowDialog();
            if (result == true)
            {                
                clientService.Update(clVM);
                ew.Close();
                orgs = orgService.GetAll();
                clients = clientService.GetAll();
                OrgBox.ItemsSource = orgs;
                ClientBox.ItemsSource = clients;
            }            
        }

        private void AddOrder_Click(object sender, RoutedEventArgs e)
        {            
            var ordVM = new OrderViewModel();
            ordVM.OrderData_Payment = "01.01.2017";
            ordVM.OrderData_Shipment = "01.01.2017";
            EditWindowOrder ew = new EditWindowOrder(ordVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                var client = ClientBox.SelectedItem as ClientViewModel;
                client.Orders.Add(ordVM);
                orderService.AddOrderToClient(client.ClientID, ordVM);
                ew.Close();
                //orgs = orgService.GetAll();
                //clients = clientService.GetAll();
                orders = orderService.GetAll();
                //OrgBox.ItemsSource = orgs;
                //ClientBox.ItemsSource = clients;
                OrderBox.ItemsSource = orders;
                payments = paymentService.GetAll();
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void DeleteOrder_Click(object sender, RoutedEventArgs e)
        {            
            var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);
            if (result == MessageBoxResult.Yes)
            {
                OrderViewModel ordVM = OrderBox.SelectedItem as OrderViewModel;
                var client = ClientBox.SelectedItem as ClientViewModel;
                //client.Orders.Remove(ordVM);
                orderService.RemoveOrderFromClient(client.ClientID, ordVM);
                orders = orderService.GetAll();              
                OrderBox.ItemsSource = orders;
                payments = paymentService.GetAll();
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            OrderViewModel ordVM = OrderBox.SelectedItem as OrderViewModel;
            EditWindowOrder ew = new EditWindowOrder(ordVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                orderService.Update(ordVM);
                ew.Close();
                orgs = orgService.GetAll();
                clients = clientService.GetAll();
                orders = orderService.GetAll();
                OrgBox.ItemsSource = orgs;
                ClientBox.ItemsSource = clients;
                OrderBox.ItemsSource = orders;
            }            
        }

        private void AddPayment_Click(object sender, RoutedEventArgs e)
        {
            var payment = OrderBox.SelectedItem as OrderViewModel;
            var pmntVM = new PaymentViewModel();
            pmntVM.PaymentData = "01.01.2017";
            EditWindowPayment ew = new EditWindowPayment(pmntVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                paymentService.AddPaymentToOrder(payment.OrderID, pmntVM);
                ew.Close();
                //orgs = orgService.GetAll();
                //clients = clientService.GetAll();
                //orders = orderService.GetAll();
                payments = paymentService.GetAll();
                //OrgBox.ItemsSource = orgs;
                //ClientBox.ItemsSource = clients;
                //OrderBox.ItemsSource = orders;
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void DeletePayment_Click(object sender, RoutedEventArgs e)
        {
            if (PaymentGrid.SelectedItem != null)
            {
                var result = MessageBox.Show("Are you sure?", "Delete", MessageBoxButton.YesNo);
                if (result == MessageBoxResult.Yes)
                {
                    PaymentViewModel pmntVM = PaymentGrid.SelectedItem as PaymentViewModel;
                    var order = OrderBox.SelectedItem as OrderViewModel;
                    paymentService.RemovePaymentFromOrder(order.OrderID, pmntVM);
                    //orgs = orgService.GetAll();
                    //clients = clientService.GetAll();
                    //orders = orderService.GetAll();
                    //OrgBox.ItemsSource = orgs;
                    //ClientBox.ItemsSource = clients;
                    //OrderBox.ItemsSource = orders;
                    payments = paymentService.GetAll();
                    PaymentGrid.ItemsSource = payments;
                }
            }
            else MessageBox.Show("Choose some Payment First", "Choose", MessageBoxButton.OK);
        }

        private void UpdatePayment_Click(object sender, RoutedEventArgs e)
        {
            PaymentViewModel pmntVM = PaymentGrid.SelectedItem as PaymentViewModel;
            EditWindowPayment ew = new EditWindowPayment(pmntVM);
            var result = ew.ShowDialog();
            if (result == true)
            {
                paymentService.Update(pmntVM);
                ew.Close();
                orgs = orgService.GetAll();
                clients = clientService.GetAll();
                orders = orderService.GetAll();
                payments = paymentService.GetAll();
                OrgBox.ItemsSource = orgs;
                ClientBox.ItemsSource = clients;
                OrderBox.ItemsSource = orders;
                PaymentGrid.ItemsSource = payments;
            }            
        }

        private void OrderBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrderBox.SelectedItem != null)
            {
                orders = orderService.GetAll();
                var orderTemp = OrderBox.SelectedItem as OrderViewModel;
                var order = orderService.Get(orderTemp.OrderID);
                payments = order.Payments;
                PaymentGrid.ItemsSource = payments;
            }
        }

        private void dGrid_LoadingRow(object sender, DataGridRowEventArgs e)
        {
            e.Row.Header = e.Row.GetIndex() + 1;
        }

        private void OrgBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (OrgBox.SelectedItem != null)
            {
                var orgTemp = OrgBox.SelectedItem as OrgViewModel;
                var curOrg = orgService.Get(orgTemp.OrgID);
                var client = orgTemp.Clients;
                ClientBox.ItemsSource = client;
            }
        }

        private void ClientBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ClientBox.SelectedItem != null)
            {
                //clients = clientService.GetAll();                
                var clientTemp = ClientBox.SelectedItem as ClientViewModel;
                //var curClient = clientService.Get(clientTemp.ClientID);
                //var order = curClient.Orders;
                var client = clientService.Get(clientTemp.ClientID);
                orders = client.Orders;
                OrderBox.ItemsSource = orders;
            }
        }       
    }
}
