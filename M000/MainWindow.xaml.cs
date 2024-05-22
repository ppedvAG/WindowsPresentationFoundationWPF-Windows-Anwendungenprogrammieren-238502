using System.Windows;

namespace M000;

public partial class MainWindow : Window
{
	public Person person { get; set; } = new Person();

	public MainWindow()
	{
		InitializeComponent();
	}

	private void PersonAnzeigen(object sender, RoutedEventArgs e)
	{
		MessageBox.Show($"{person.Vorname}\n{person.Nachname}\n{person.GebDat}\n{person.Verheiratet}\n{person.Lieblingsfarbe}\n{person.Geschlecht}");
	}
}