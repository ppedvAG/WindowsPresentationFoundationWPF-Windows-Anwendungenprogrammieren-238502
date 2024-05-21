using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M002;

public partial class MainWindow : Window
{
	private int Counter;

	public MainWindow()
	{
		InitializeComponent();

		CB.ItemsSource = Enum.GetValues<DayOfWeek>();
	}

	private void Button_Click(object sender, RoutedEventArgs e)
	{
		Counter++;
		//Output.Text = Counter.ToString();
		Output.Text = Input.Text;
	}

	private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
	{
		ComboBox cb = sender as ComboBox;
		//ComboBoxItem item = cb.SelectedItem as ComboBoxItem;
		Output.Text = cb.SelectedItem.ToString();
	}

	private void Check_Checked(object sender, RoutedEventArgs e)
	{
		Input.Visibility = Visibility.Visible;
	}

	private void Check_Unchecked(object sender, RoutedEventArgs e)
	{
		Input.Visibility = Visibility.Collapsed;
	}

	private void Slider_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
	{
		Slider s = sender as Slider;
		//Output.Text = s.Value.ToString();
		if (IsInitialized)
			Progress.Value = s.Value;
	}

	private void MenuItem_Click(object sender, RoutedEventArgs e)
	{
		MessageBoxResult result = MessageBox.Show("Willst du wirklich beenden?", "Beenden", MessageBoxButton.YesNo, MessageBoxImage.Question);
		if (result == MessageBoxResult.Yes)
			Close();
	}
}