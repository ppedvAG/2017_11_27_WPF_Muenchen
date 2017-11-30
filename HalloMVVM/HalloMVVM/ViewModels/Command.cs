using System;
using System.ComponentModel;
using System.Windows.Input;

namespace HalloMVVM.ViewModels
{
    internal class Command : ICommand
    {
        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action execute) => this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
        public Command(Action execute, Func<bool> canExecute) : this(execute) => this.canExecute = canExecute;

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => execute();

        public Command ObservesProperty(INotifyPropertyChanged viewModel, string propertyName)
        {
            viewModel.PropertyChanged += (s, args) =>
            {
                if (args.PropertyName == propertyName)
                    CanExecuteChanged?.Invoke(this, new EventArgs());
            };
            return this;
        }
    }
}
