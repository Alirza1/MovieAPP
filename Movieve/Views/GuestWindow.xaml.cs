using Movieve.ViewModels;
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

namespace Movieve
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.DataContext = new GuestViewModel();
            InitializeComponent();
        }
        public void SearchPanelOn()
        {
            SearchPanel.Visibility = Visibility.Visible;
        }
        private void SearchPanelOn(object sender, RoutedEventArgs e)
        {
            SearchPanelOn();
        }
        private void SearchPanelOn(object sender, MouseButtonEventArgs e)
        {
            SearchPanelOn();
        }
    }
}
