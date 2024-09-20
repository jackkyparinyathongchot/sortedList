using System.Collections;
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

namespace SortedListApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SortedList sortedList;
        public MainWindow()
        {
            InitializeComponent();
            sortedList = new SortedList();
        }

        private void addbt_Click(object sender, RoutedEventArgs e)
        {
            //string
            sortedList.Add(int.Parse(txtKey.Text), txtValue.Text);
            string display = "";
            ICollection collection = sortedList.Keys;
            foreach (int key in collection)
            {
                display = display + key + " = "+sortedList[key].ToString()+"\n";
            }
            MessageBox.Show(display);
            //int
            /*sortedList.Add(int.Parse(txtKey.Text), txtValue.Text);
            ICollection collection = sortedList.Keys;
            foreach (string key in collection)
            {
                MessageBox.Show(sortedList[key].ToString());
            }*/
        }
    }
}