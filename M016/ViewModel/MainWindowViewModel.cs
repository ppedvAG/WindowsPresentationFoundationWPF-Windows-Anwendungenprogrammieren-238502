using System.Collections.ObjectModel;
using System.IO;
using System.Text.Json;
using System.Windows;
using M016.Model;

namespace M016.ViewModel;

public class MainWindowViewModel : ViewModelBase
{
	public ObservableCollection<Person> Personen { get; set; } = new();

	public CustomCommand DeletePerson { get; set; } = new();

	public MainWindowViewModel()
	{
		string readJson = File.ReadAllText("Personen.json");
		List<Person> p = JsonSerializer.Deserialize<List<Person>>(readJson)!;
		foreach (Person person in p)
		{
			Personen.Add(person);
		}

		DeletePerson.ExecuteMethod = DeletePersonMethod;
	}

	public void DeletePersonMethod(object o)
	{
		Person p = (Person) o;
		if (MessageBox.Show($"Möchstest du die Person {p.ID} wirklich löschen?", "Person löschen", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
		{
			Personen.Remove(p);
		}
	}
}