using M015.Model;
using System.Windows;
using System.Windows.Media;

namespace M015.ViewModel;

public class MainWindowViewModel
{
	public Person DiePerson { get; set; } = new();

	public CustomCommand PrintPerson { get; set; } = new();

	/// <summary>
	/// Wird nach InitializeComponent ausgeführt
	/// </summary>
    public MainWindowViewModel()
    {
		DiePerson.Vorname = "Max";
		DiePerson.Nachname = "Mustermann";
		DiePerson.Verheiratet = true;
		DiePerson.Lieblingsfarbe = Colors.DeepPink;

		PrintPerson.ExecuteMethod = PrintPersonMethod;
    }

	public void PrintPersonMethod(object o)
	{
		MessageBox.Show($"{DiePerson.Vorname}\n{DiePerson.Nachname}\n{DiePerson.GebDat}\n{DiePerson.Verheiratet}\n{DiePerson.Lieblingsfarbe}");
	}
}