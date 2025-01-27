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

namespace _02._11
{
    /// <summary>
    /// Логика взаимодействия для window_component.xaml
    /// </summary>
    public partial class window_component : Window
    {
        List<string> processor = new List<string>() { "model: intel core i5", "cores: 4", "power: 3.2gz" };
        List<string> gpu = new List<string>() { "model: RTX 350", "ram memory 6", "power: 14000gz" };
        List<string> RAM = new List<string>() { "model: kingston", "memory: 8Gb", "power: 32000gz" };
        List<string> cooler = new List<string>() { "model: deepcool", "speed: 1200", "power: 65 vt" };
        List<string> hdd = new List<string>() { "model: segate", "memory: 1 tb", "read: 120 mb", "write: 50 mb" };
        List<string> ssd = new List<string>() { "model: kingston", "memory: 512 gb", "read: 500 mb", "write: 450 mb" };
        List<string> monitor = new List<string>() { "model: xiaomi red 12", "diagonal: 27", "power: 144 gz" };
        List<string> keyboard = new List<string>() { "model: keyron", "key: mechanic", "keys count: 125" };
        List<string> mous = new List<string>() { "model: qumo axe", "key count: 6", "power: 12400 dpi" };
        Dictionary<string, List<string>> charactik = new Dictionary<string, List<string>>
        {
            { "Processor", new List<string>() { "model: intel core i5", "cores: 4", "power: 3.2gz" } },
            {"graphics card", new List<string>() { "model: RTX 350", "ram memory 6", "power: 14000gz" } },
            {"RAM", new List<string>() { "model: kingston", "memory: 8Gb", "power: 32000gz" } },
            {"CPU cooler", new List<string>() { "model: deepcool", "speed: 1200", "power: 65 vt" } },
            {"hard disk", new List<string>() { "model: segate", "memory: 1 tb", "read: 120 mb", "write: 50 mb" } },
            { "ssd", new List<string>() { "model: kingston", "memory: 512 gb", "read: 500 mb", "write: 450 mb" } },
            {"monitor", new List<string>() { "model: xiaomi red 12", "diagonal: 27", "power: 144 gz" } },
            {"keyboard", new List<string>() { "model: keyron", "key: mechanic", "keys count: 125" } },
            {"mous", new List<string>() { "model: qumo axe", "key count: 6", "power: 12400 dpi" } }
        };
        public window_component()
        {
            InitializeComponent();
        }

        private void list_component_LostFocus(object sender, RoutedEventArgs e)
        {
            if (list_component.Text.Length > 1)
            {
                characteristiks.Text = string.Join("\n", charactik[list_component.Text]);
            }
        }

        private void characteristiks_LostFocus(object sender, RoutedEventArgs e)
        {
            if (characteristiks.Text != string.Join("\n", charactik[list_component.Text]))
            {
                charactik[list_component.Text] = characteristiks.Text.Split('\n').ToList();
            }
        }
    }
}
