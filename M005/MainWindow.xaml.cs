using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;

namespace M005;

public partial class MainWindow : Window, INotifyPropertyChanged
{
	private int zaehler = 10;

	public int Zaehler
	{
		get => zaehler;
		set
		{
			zaehler = value;
			Notify(nameof(Zaehler));
		}
	}

	public ObservableCollection<int> Zahlen { get; set; } = new();

	public BindableProperty<int> Zaehler2 { get; set; } = new();

	public MainWindow()
	{
		InitializeComponent();
		//this.DataContext = this;
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Zaehler++;
	}

	private void Button_Click_1(object sender, RoutedEventArgs e)
	{
		Zahlen.Add(Random.Shared.Next());
	}

	private void Button_Click_2(object sender, RoutedEventArgs e)
	{
		Zaehler2.Value++;
	}

	public event PropertyChangedEventHandler? PropertyChanged;

	public void Notify(string propertyName) =>
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

	//Alternative:
	//public void Notify([CallerMemberName] string propertyName = "") =>
	//	PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}