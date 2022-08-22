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

namespace Timer
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
        public event EventHandler Start = null;
        public event EventHandler Stop = null;
        public event EventHandler Reset = null;

        private void StartButton_Click(object sender, RoutedEventArgs e)
        {
            Start.Invoke(sender, e);
        }

        private void PauseButton_Click(object sender, RoutedEventArgs e)
        {
            Stop.Invoke(sender, e);
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            Reset.Invoke(sender, e);
        }
    }
}
