using System;
using System.Collections.Generic;
using System.Text;
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
    /// Логика взаимодействия для CurrentTableWindow.xaml
    /// </summary>
    public partial class CurrentTableWindow : Window
    {
        public CurrentTableWindow()
        {
            InitializeComponent();
        }

        private void Back_Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow Win = new MainWindow();
            Win.Show();
            this.Close();
        }

        private void ordersList_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            return;
        }
    }
}
