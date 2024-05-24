using System.ComponentModel;
using System.Windows;

namespace M014;

public partial class MainWindow : Window
{
	public ExitCommand ExitCommand { get; set; } = new();

	public CustomCommand NeuePerson { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();
		//Hier Methodenzeiger für Execute und CanExecute anhängen
		NeuePerson.ExecuteMethod = OpenWindow;
		NeuePerson.CanExecuteMethod = NeuesFensterMoeglich;
	}

	public void OpenWindow(object o)
	{
		MainWindow mw = new MainWindow();
		mw.Show();
	}

	public bool NeuesFensterMoeglich(object? o)
	{
		if (o == null)
			return false;

		double d = (double) o;
		return d >= 5;
	}
}