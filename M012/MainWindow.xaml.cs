using System.Collections.ObjectModel;
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

namespace M012;

public partial class MainWindow : Window
{
	public ObservableCollection<int> Zahlen { get; set; } = new([1, 1, ..Enumerable.Range(1, 100)]);

	public MainWindow()
	{
		InitializeComponent();
	}
}