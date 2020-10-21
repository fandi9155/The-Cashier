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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace The_Cashier
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox1.ItemsSource = calculator.getListItem();
        }

        private void AddButton_click(object sender, RoutedEventArgs e)
        {
            string titl = itemNameBox.Text;
            int quantuty = int.Parse(quantityBox.Text);
            string type = typeBox.Text;
            double price = double.Parse(priceBox.Text);

            Item item = new Item(new Random().Next(), Title, quantuty, price, type);
            calculator.addItem(item);
            double total = calculator.getTotal();

            totalLebel.Content = String.Format("Rp. {0}", total);
            listBox.Items.Refresh();
                


        }
    }
}
