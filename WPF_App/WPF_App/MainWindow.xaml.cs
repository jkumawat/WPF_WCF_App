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

namespace WPF_App
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

        private void btnPerform_Click(object sender, RoutedEventArgs e)
        {
            WCFArithmaticService.ArithmaticServiceClient service = new WCFArithmaticService.ArithmaticServiceClient();

            WCFArithmaticService.Operand operand = new WCFArithmaticService.Operand();

            operand.Operand_one = Convert.ToInt32(txtNumberOne.Text);
            operand.Operand_two = Convert.ToInt32(txtNumberTwo.Text);

            txtResultAdd.Text = string.Format("value : {0}", service.GetAddition(operand).ToString());
            txtResultSubtract.Text = string.Format("value : {0}", service.GetSubtraction(operand).ToString());
            txtResultMultiply.Text = string.Format("value : {0}", service.GetMultiplicaiton(operand).ToString());
            txtResultDivide.Text = string.Format("value : {0}", service.GetDivide(operand).ToString());
        }
    }
}
