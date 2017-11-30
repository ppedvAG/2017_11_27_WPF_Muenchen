using System.Windows;

namespace HalloMVVM.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //DataContext = new ViewModels.MainWindowViewModel();
        }

        private void ChangeText(object sender, RoutedEventArgs e) => (DataContext as ViewModels.MainWindowViewModel).WelcomeText = "Mein neuer Text aus dem Code Behind";
    }
}
