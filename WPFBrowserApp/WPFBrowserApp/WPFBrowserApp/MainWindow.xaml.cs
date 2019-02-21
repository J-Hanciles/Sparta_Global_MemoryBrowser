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

namespace WPFBrowserApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> comboBoxDataSource = new List<string>();
        public MainWindow()
        {
            InitializeComponent();
            populateCombo();
            foreach (var item in comboBoxDataSource)
            {
                combo1.Items.Add(item);
            }
            brwControl.Navigate("http://www.spartaglobal.com");
            
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            string item = combo1.SelectedItem.ToString();
            brwControl.Navigate(item);
        }
        public void populateCombo()
        {
            comboBoxDataSource.Add("http://www.google.co.uk");
            comboBoxDataSource.Add("http://www.yahoo.com");
            comboBoxDataSource.Add("http://www.aws.com");
        }
        private void OnKeyPress(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                brwControl.Navigate(combo1.Text);
            }
        }
    }
}
