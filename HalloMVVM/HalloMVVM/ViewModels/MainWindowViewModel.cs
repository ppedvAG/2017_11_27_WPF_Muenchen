namespace HalloMVVM.ViewModels
{
    internal class MainWindowViewModel : ViewModelBase
    {
        private string welcomeText = "Hallo MVVM!";
        public string WelcomeText
        {
            get => welcomeText;
            set => Set(ref welcomeText, value);
        }
    }
}
