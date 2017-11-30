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

        public Command ChangeTextCommand { get; }

        public MainWindowViewModel()
        {
            ChangeTextCommand = new Command(() => WelcomeText = "Hallo aus dem VM!", () => WelcomeText?.Length < 10)
                .ObservesProperty(this, nameof(WelcomeText));
        }
    }
}
