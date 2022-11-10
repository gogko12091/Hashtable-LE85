using System;
using System.Collections;
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

namespace HashtableWork
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Hashtable hashTable;
        public MainWindow()
        {
            InitializeComponent();
            hashTable = new Hashtable();
        }

        private void ADD_Click(object sender, RoutedEventArgs e)
        {
            hashTable.Add(key.Text,value.Text);
            
        }

        private void REMOVE_Click(object sender, RoutedEventArgs e)
        {
            hashTable.Remove(key);
        }
        private void SHOWALL_Click(object sender, RoutedEventArgs e)
        {
            int i = 1;
            if(hashTable.Count == 0)
            {
                MessageBox.Show("No DATA");
            }
            else
            {
                ICollection icollection = hashTable.Keys;
                foreach (string KEY in icollection)
                {
                    MessageBox.Show(hashTable[KEY].ToString(), "DATA NUBER" + i.ToString());
                    i++;
                }
            }
           
        }
        
    }
}
