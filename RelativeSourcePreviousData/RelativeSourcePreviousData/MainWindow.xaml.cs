using System.Collections.Generic;
using System.Windows;

namespace RelativeSourcePreviousData
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            dataView.ItemsSource = GetValues();
        }

        private IList<Item> GetValues() => new List<Item>
        {
            new Item { Value = 84 },
            new Item { Value = 0 },
            new Item { Value = 46},
            new Item { Value = 4 },
            new Item { Value = 85 },
            new Item { Value = 100 },
            new Item { Value = 16 },
            new Item { Value = 99 },
            new Item { Value = 129 },
            new Item { Value = 70 },
            new Item { Value = 34 },
            new Item { Value = 267 },
            new Item { Value = 86 },
            new Item { Value = 3 },
            new Item { Value = 84 },
        };
    }
}
