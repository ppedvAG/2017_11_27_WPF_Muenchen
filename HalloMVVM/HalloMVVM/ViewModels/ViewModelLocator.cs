namespace HalloMVVM.ViewModels
{
    internal class ViewModelLocator
    {
        public MainWindowViewModel MainWindowViewModel { get; }

        public ViewModelLocator()
        {
            MainWindowViewModel = new MainWindowViewModel(/* new Service(), etc.... */);
            //MainWindowViewModel = container.GetInstance<MainWindowViewModel>();
        }
    }
}
