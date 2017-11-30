using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Input;

namespace HalloMVVM.ViewModels
{
    internal class Command : ICommand, IDisposable
    {
        private readonly List<(INotifyPropertyChanged viewModel, PropertyChangedEventHandler eventHandler)> observedProperties = new List<(INotifyPropertyChanged, PropertyChangedEventHandler)>();

        private readonly Action execute;
        private readonly Func<bool> canExecute;

        public event EventHandler CanExecuteChanged;

        public Command(Action execute) => this.execute = execute ?? throw new ArgumentNullException(nameof(execute));
        public Command(Action execute, Func<bool> canExecute) : this(execute) => this.canExecute = canExecute;

        public bool CanExecute(object parameter) => canExecute?.Invoke() ?? true;
        public void Execute(object parameter) => execute();

        public Command ObservesProperty(INotifyPropertyChanged viewModel, string propertyName)
        {
            PropertyChangedEventHandler canExecuteChanged = (s, args) =>
            {
                if (args.PropertyName == propertyName)
                    CanExecuteChanged?.Invoke(this, new EventArgs());
            };
            viewModel.PropertyChanged += canExecuteChanged;
            observedProperties.Add((viewModel, canExecuteChanged));

            return this;
        }

        private bool isDisposed;
        public void Dispose()
        {
            if (isDisposed)
                return;

            observedProperties.ForEach(e => e.viewModel.PropertyChanged -= e.eventHandler);
            observedProperties.Clear();

            isDisposed = true;
        }

        ~Command() => Dispose();
    }
}
