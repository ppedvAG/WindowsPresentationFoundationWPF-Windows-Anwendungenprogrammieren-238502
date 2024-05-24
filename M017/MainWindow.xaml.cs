using M017.Models;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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

namespace M017;

public partial class MainWindow : Window
{
	public ObservableCollection<Order> Daten { get; set; } = new ObservableCollection<Order>();

	public MainWindow()
	{
		InitializeComponent();

		//Basic SQL Connection
		//SqlConnection conn = new SqlConnection("Data Source=WIN10-LK3;Initial Catalog=Northwind;Integrated Security=True;Encrypt=False");
		//conn.Open();

		//SqlCommand command = conn.CreateCommand();
		//command.CommandText = "SELECT * FROM Customers";

		//SqlDataReader reader = command.ExecuteReader();
		//while (reader.Read())
		//{
		//	object[] singleRecord = new object[reader.VisibleFieldCount];
		//	reader.GetValues(singleRecord);
		//	Daten.Add(singleRecord);
		//}

		//EntityFramework
		//NuGet: Microsoft.EFCore, Microsoft.EFCore.SqlServer
		//VS Extension: EFCore Power Tools

		NorthwindContext nc = new();
		foreach (Order c in nc.Orders)
			Daten.Add(c);
	}
}