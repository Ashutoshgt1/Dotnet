using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        double firstnum, secondnum, result;
        string selectdoperator = "";
        public void Operator_Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt1 = sender as Button;
            selectdoperator = bt1.Content.ToString();
            firstnum = Convert.ToDouble(dspl.Text);
            dspl.Text = "0";



        }
        public void Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            if (dspl.Text == "0" && bt.Content.ToString() == ".")
            {
                dspl.Text = " 0";
            }
            if (dspl.Text == "0" && bt.Content.ToString() != ".") { 
                dspl.Text = bt.Content.ToString();
                return;
            }
            if (dspl.Text.Contains(".") && bt.Content.ToString() != ".") {
                return;
            }
            else
            {
                dspl.Text += bt.Content.ToString();
            }
        }
        public void AC_Button_Click(object sender, RoutedEventArgs e)
        {
            dspl.Text = "0";

        }
        public void minusone_Button_Click(object sender, RoutedEventArgs e)
        {
            dspl.Text=(-1*Convert.ToDouble(dspl.Text)).ToString();

        }
        public void Equal_Button_Click(object sender, RoutedEventArgs e)
        {
            Button bt = sender as Button;
            if (dspl.Text == "0" && bt.Content.ToString() == ".") {
                dspl.Text = "0";
                return;

            }
            if (dspl.Text == "0" && bt.Content.ToString()!= ".")
            {
                
                dspl.Text = bt.Content.ToString();
                return;

            }
            if (dspl.Text == "0" && bt.Content.ToString()== ".")
            {
                dspl.Text = "0";
            }
            if (dspl.Text == "0" && bt.Content.ToString() == ".")
            {
                dspl.Text = "0";
            }

        }
    }
}