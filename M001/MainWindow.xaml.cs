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

namespace M001;

public partial class MainWindow : Window
{
	public MainWindow()
	{
		InitializeComponent();

		TestButton.FontSize = 50;
	}

	private void TestButton_Click(object sender, RoutedEventArgs e)
	{
		MessageBox.Show("Hallo");
	}

	private void TestButton_MouseEnter(object sender, MouseEventArgs e)
	{
		if (TestButton.FontSize > 1)
			TestButton.FontSize--;
    }
}