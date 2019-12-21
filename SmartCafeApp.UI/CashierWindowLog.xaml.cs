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

namespace SmartCafeApp.UI
{
    /// <summary>
    /// Логика взаимодействия для CashierWindowLog.xaml
    /// </summary>
    public partial class CashierWindowLog : Window
    {
        public CashierWindowLog()
        {
            InitializeComponent();
        }

        private void Cashier_Log_Click(object sender, RoutedEventArgs e)
        {
            CashierModeWindow Win = new CashierModeWindow();
            Win.Show();
            this.Close();
        }

        private void Cancel_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Win = new MainWindow();
            Win.Show();
            this.Close();
        }
    }
}
