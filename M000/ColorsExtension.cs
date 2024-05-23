using System.Reflection;
using System.Windows.Data;
using System.Windows.Markup;
using System.Windows.Media;

namespace M000;

public class ColorsExtension : MarkupExtension
{
	//<ObjectDataProvider x:Key="Odp_Colors" MethodName="GetType" ObjectType="{x:Type sys:Type}">
	//	<ObjectDataProvider.MethodParameters>
	//		<sys:String>
	//			System.Windows.Media.Colors, PresentationCore, Version=3.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35
	//		</sys:String>
	//	</ObjectDataProvider.MethodParameters>
	//</ObjectDataProvider>
	//<ObjectDataProvider x:Key="Odp_ColorsProperties" MethodName="GetProperties" ObjectInstance="{StaticResource Odp_Colors}"/>

	public override object ProvideValue(IServiceProvider serviceProvider)
	{
		//PropertyInfo[] properties = typeof(Colors).GetProperties();
		////PropertyInfo[] zu Color[] konvertieren
		//List<NamedColor> colors = new List<NamedColor>();
		//foreach (PropertyInfo prop in properties)
		//{
		//	colors.Add(new NamedColor((Color) prop.GetValue(null), prop.Name)); //null weil die Properties static sind
		//}
		//return colors;

		return typeof(Colors).GetProperties().Select(prop => new NamedColor((Color) prop.GetValue(null), prop.Name));
	}
}

public class NamedColor
{
	public Color Farbe { get; set; }

	public string Name { get; set; }

	public SolidColorBrush Brush { get; }
	
	public NamedColor(Color farbe, string name)
	{
		Farbe = farbe;
		Name = name;
		Brush = new SolidColorBrush(Farbe);
	}
}