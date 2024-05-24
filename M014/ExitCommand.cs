using System.Windows.Input;

namespace M014;

public class ExitCommand : ICommand
{
	public event EventHandler? CanExecuteChanged;

	/// <summary>
	/// Code, der bei Click ausgeführt wird
	/// </summary>
	public void Execute(object? parameter)
	{
		Environment.Exit(0);
	}

	/// <summary>
	/// Gibt zurück, ob das Command gerade ausgeführt werden kann
	/// Steuert beim Button IsEnabled
	/// </summary>
	public bool CanExecute(object? parameter)
	{
		if (parameter == null)
			return false;

		double d = (double) parameter;
		return d >= 5;
	}
}