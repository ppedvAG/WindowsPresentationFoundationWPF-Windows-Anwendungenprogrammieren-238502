using System.Windows.Input;

namespace M016;

public class CustomCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	public Action<object> ExecuteMethod;

	public Func<object, bool> CanExecuteMethod;

	/// <summary>
	/// Bei CustomCommand kann über die beiden Parameter vom Konstruktor ein Methodenzeiger übergeben werden
	/// 
	/// Dadurch kann ich bei Erstellung des Commands beliebigen Code hier einfügen
	/// 
	/// Action: Methode ohne Rückgabewert
	/// Func: Methode mit Rückgabewert
	/// </summary>
	public CustomCommand(Action<object> execute, Func<object, bool> canExecute) : this()
	{
		ExecuteMethod = execute;
		CanExecuteMethod = canExecute;
	}

    public CustomCommand()
	{
		CanExecuteMethod = o => true;
	}

    public void Execute(object? parameter)
	{
		ExecuteMethod?.Invoke(parameter);
	}

	public bool CanExecute(object? parameter)
	{
		return CanExecuteMethod.Invoke(parameter);
	}
}