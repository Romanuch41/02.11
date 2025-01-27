using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace _02._11
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<string, int> components = new Dictionary<string, int>()
        {
            { "Processor", 100 }, {"graphics card", 350 }, {"RAM", 30 }, {"CPU cooler", 10 }, {"hard disk", 50 },
            { "ssd", 55 }, {"monitor", 79 }, {"keyboard", 15 }, {"mous", 10 }
        };
        public MainWindow()
        {
            InitializeComponent();
        }

        private void search_Click(object sender, RoutedEventArgs e)
        {
            Window1 search_window = new Window1();
            search_window.Show();
        }

        private void add_component_Click(object sender, RoutedEventArgs e)
        {
            list_price.Items.Add(list_component.Text);
            int all_price = 0;
            foreach (var item in list_price.Items)
            {
                all_price = all_price + components[item.ToString()];
            }
            full_price.Content = all_price.ToString();
        }

        private void list_component_LostFocus(object sender, RoutedEventArgs e)
        {
            if (list_component.Text.Length > 1)
            {
                price_component.Content = "price:" + " " + components[list_component.Text];
            }
        }

        private void components_form_Click(object sender, RoutedEventArgs e)
        {
            window_component wincom = new window_component();
            wincom.Show();
        }
    }
}
