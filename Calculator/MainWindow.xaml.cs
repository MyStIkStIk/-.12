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

namespace Calculator
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            new Presentation(this);
        }
        public event EventHandler Plus = null;
        public event EventHandler Minus = null;
        public event EventHandler Multi = null;
        public event EventHandler Delit = null;
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Plus.Invoke(sender, e);
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Minus.Invoke(sender, e);
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Multi.Invoke(sender, e);
        }
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Delit.Invoke(sender, e);
        }
    }
}
