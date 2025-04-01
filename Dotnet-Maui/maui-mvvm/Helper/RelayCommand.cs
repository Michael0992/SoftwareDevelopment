﻿using System.Windows.Input;

namespace maui_mvvm.Helper;

public class RelayCommand : ICommand
{
    private Action<object?> execute;
    private Func<object?, bool>? canExecute;

    public event EventHandler? CanExecuteChanged;

    public RelayCommand(
        Action<object?> execute,
        Func<object?, bool>? canExecute = null)
    {
        this.execute = execute;
        this.canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        return canExecute == null || canExecute(parameter);
    }

    public void Execute(object? parameter)
    {
        execute(parameter);
    }
}
