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

namespace _02._11
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void name_folder_GotFocus(object sender, RoutedEventArgs e)
        {
            name_folder.Clear();
        }

        private void name_folder_LostFocus(object sender, RoutedEventArgs e)
        {
            if (name_folder.Text.Length == 0)
            {
                name_folder.Text = "Имя папки";
            }
        }

        private void search_folder_Click(object sender, RoutedEventArgs e)
        {
            Search_folder fdir = new Search_folder();
            string target_folder = fdir.Find_folder(name_folder.Text);
            if (target_folder == "directory is not exists")
            {
                MessageBox.Show("Директория не найдена");
                return;
            }
            string files = "";
            foreach (string file in fdir.Get_files(target_folder))
            {
                if (file.Contains(file_type.Text))
                    files += file.Split('\\').Last() + "\n";
            }
            file_list.Content = files;
        }
    }

    public class Search_folder
    {
        public Search_folder() { }
        public string Check_folder(DirectoryInfo[] name, string folder_name)
        {
            string er = "directory is not exists";
            foreach (DirectoryInfo subdir in name)
            {
                if (subdir.Name == folder_name)
                {
                    MessageBox.Show("Есть директория");
                    er = subdir.FullName;
                    return subdir.FullName;
                }
                else
                {
                    try
                    {
                        DirectoryInfo[] subdirs = subdir.GetDirectories();
                        string result = Check_folder(subdirs, folder_name);
                        if (result.Contains(folder_name))
                            return result;
                    }
                    catch (UnauthorizedAccessException e)
                    {
                        continue;
                    }
                    catch (DirectoryNotFoundException e)
                    {
                        continue;
                    }
                }
            }
            return er;
        }
        public string Find_folder(string folder_name)
        {
            string start_point = @"C:\";
            DirectoryInfo[] sub = new DirectoryInfo(start_point).GetDirectories();
            string target_folder = Check_folder(sub, folder_name);
            return target_folder;
        }

        public string[] Get_files(string full_dir_name)
        {

            return Directory.GetFiles(full_dir_name);
        }
    }
}
