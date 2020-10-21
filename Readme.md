# The Cashier 

Aplikasi ini Digunakan pada kasir pada toko sehingga bisa mebantu di bagian keuangan.

## Scopre & Funvtionalities
- User dapat meninputkan data
- user dapat memilih type pesanan
- user dapat menjumlah kan total barang 
- user dapat menampilkan harga




## Logika Perhitungan pada Aplikasi Cashier 
'''
csharp


    class Calculator
    {
        private List<Item> listItem;
        private double total = 0;

        public Calculator()
        {
            this.listItem = new List<Item>();
        }
'''
## How Does it Work ?
Di awali dengan Main Windows

'''
 public partial class MainWindow : Window
    {
        private Calculator calculator;
        public MainWindow()
        {
            InitializeComponent();
            calculator = new Calculator();
            listBox1.ItemsSource = calculator.getListItem();
        }
'''