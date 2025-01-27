using Microsoft.Win32;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _02._11._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string path = "";
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            fileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            Nullable<bool> result = fileDialog.ShowDialog();
            if (result == true)
            {
                string filePath = fileDialog.FileName;
                this.path = filePath;
                using (StreamReader stream = new StreamReader(filePath))
                {
                    string content = stream.ReadToEnd();
                    box_text.Text = content;
                    stream.Close();
                }
            }
            edit_file.IsEnabled = true;
        }

        private void edit_file_Click(object sender, RoutedEventArgs e)
        {
            Window_edit_file window_Edit_File = new Window_edit_file();
            window_Edit_File.Owner = this;
            window_Edit_File.Show();
            window_Edit_File.edit_text.Text = box_text.Text;
            window_Edit_File.path = this.path;
        }
    }
}
