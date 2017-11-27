using System.Windows;
using System.Windows.Input;

namespace HalloWPF
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

        private void previewMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (sender is Window w)
                MessageBox.Show(w.Name);
            else
                MessageBox.Show("Was anderes");

            //e.Handled = true;
        }
    }
}
