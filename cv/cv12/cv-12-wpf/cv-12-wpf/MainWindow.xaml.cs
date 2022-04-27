using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
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

namespace cv_12_wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private string a, b, op;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Operation_SelectionChanged(object sender, RoutedEventArgs e)
        {
            op = Operation.Text;
        }

  

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            a = OperandA.Text;
            b = OperandB.Text;
            op = Operation.Text;

            if (a != null && b != null && op != null)
            {
                // vypsání výsledku
                Result.Text = String.Format("{0} {1} {2} = {3}", a, op, b, Calculate(a, b, op));
            }
        }
        private string Calculate(string a, string b, string op)
        {
            CalcData calcData = new CalcData
            {
                Operace = op,
                Operand1 = Convert.ToDecimal(a),
                Operand2 = Convert.ToDecimal(b)
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44391/");
            HttpResponseMessage response =
            client.PostAsJsonAsync("api/values", calcData).Result;
            if (response.IsSuccessStatusCode)
            {
                decimal reply = response.Content.ReadAsAsync<decimal>().Result;
                return reply.ToString();
            }
            return "Error";
        }
    }
}
