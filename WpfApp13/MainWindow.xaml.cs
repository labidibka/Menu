using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp13
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void usun_Click(object sender, RoutedEventArgs e)
        {
            if (MainTabControl.Items.Count > 0) 
            {
                MainTabControl.Items.Remove(MainTabControl.SelectedItem);
            }
        }

        private void dodaj_Click(object sender, RoutedEventArgs e)
        {
            
            TabItem newtab = new TabItem
            {
              
                Header = $"Tab {MainTabControl.Items.Count + 1}",
                Content = new TextBlock { Text = $"Zawartość Zakładki {MainTabControl.Items.Count + 1}" }
                
            };
            MainTabControl.Items.Add(newtab);
            MainTabControl.SelectedItem = newtab;
        }

       
        private void new_Click(object sender, RoutedEventArgs e)
        {

        }

        private void close_Click(object sender, RoutedEventArgs e)
        {
           
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}