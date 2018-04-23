using System.Collections.Generic;
using System.Windows;
using System.Windows.Data;
using System.ComponentModel;

namespace DXGrid_Binding_to_ICollectionView
{
    public class myData
    {
        public int ID { get; set; }
        public string item { get; set; }
    }
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
    }
}
