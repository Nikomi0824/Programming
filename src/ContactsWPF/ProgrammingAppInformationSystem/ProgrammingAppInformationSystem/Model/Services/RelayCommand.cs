using System;
using System.Windows.Input;

public class RelayCommand : ICommand
{
    private readonly Action<object> _execute;
    private readonly Predicate<object> _canExecute;

    /// <summary>
    /// Конструктор команды
    /// </summary>
    /// <param name="execute">Действие, выполняемое командой (обязательный параметр)</param>
    /// <param name="canExecute">Условие выполнения команды (опциональный параметр)</param>
    /// <exception cref="ArgumentNullException">Генерируется, если execute равен null</exception>
    public RelayCommand(Action<object> execute, Predicate<object> canExecute = null)
    {
        _execute = execute ?? throw new ArgumentNullException(nameof(execute));
        _canExecute = canExecute;
    }

    /// <summary>
    /// Определяет, может ли команда выполняться в текущем состоянии
    /// </summary>
    /// <param name="parameter">Параметр команды</param>
    public bool CanExecute(object parameter) => _canExecute?.Invoke(parameter) ?? true;

    /// <summary>
    /// Выполняет логику команды
    /// </summary>
    /// <param name="parameter">Параметр команды</param>
    public void Execute(object parameter) => _execute(parameter);

    /// <summary>
    /// Событие, возникающее при изменении возможности выполнения команды
    /// </summary>
    public event EventHandler CanExecuteChanged
    {
        add => CommandManager.RequerySuggested += value;
        remove => CommandManager.RequerySuggested -= value;
    }
}