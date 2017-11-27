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

namespace Resourcen
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

        private void changeColor(object sender, RoutedEventArgs e)
        {
            var brush = myStackpanel.FindResource("defaultBackgroundBrush") as SolidColorBrush;
            if (brush != null)
                brush.Color = Colors.CornflowerBlue;
        }

        private void changeInstance(object sender, RoutedEventArgs e)
        {
            myStackpanel.Resources["defaultBackgroundBrush"] = new SolidColorBrush(Colors.Firebrick);
        }

        private void changeType(object sender, RoutedEventArgs e)
        {
            myStackpanel.Resources["defaultBackgroundBrush"] = new LinearGradientBrush(
                Colors.Blue,
                Colors.Yellow,
                0);
        }
    }
}
