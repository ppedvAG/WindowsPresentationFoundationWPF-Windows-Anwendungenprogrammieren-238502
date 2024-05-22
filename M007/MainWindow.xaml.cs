using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;

namespace M007;

public partial class MainWindow : Window
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public ObservableCollection<int> Zahlen { get; set; } = new(Enumerable.Range(0, 100));

	public MainWindow()
	{
		Personen.Add(new Person() { Vorname = "Max", Nachname = "Mustermann", GebDat = new DateTime(1999, 11, 12) });
		Personen.Add(new Person() { Vorname = "Udo", Nachname = "Mustermann", GebDat = new DateTime(1989, 07, 19) });
		Personen.Add(new Person() { Vorname = "Tim", Nachname = "Mustermann", GebDat = new DateTime(1979, 01, 16) });

		InitializeComponent();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Button b = sender as Button;
		Person p = b.DataContext as Person;
		Personen.Remove(p);
	}
}