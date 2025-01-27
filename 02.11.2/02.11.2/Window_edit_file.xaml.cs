using System;
using System.Collections.Generic;
using System.IO;
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

namespace _02._11._2
{
    /// <summary>
    /// Логика взаимодействия для Window_edit_file.xaml
    /// </summary>
    public partial class Window_edit_file : Window
    {
        public string path = "";
        public Window_edit_file()
        {
            InitializeComponent();
        }

        private void cancel_file_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void save_file_Click(object sender, RoutedEventArgs e)
        {
            using (StreamWriter write = new StreamWriter(this.path, false))
            {
                write.Write(edit_text.Text);
                write.Close();
            }
        }
    }
}
