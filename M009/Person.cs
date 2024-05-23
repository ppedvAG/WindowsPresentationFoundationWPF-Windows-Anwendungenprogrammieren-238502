using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace M009;

public class Person : INotifyPropertyChanged, IDataErrorInfo
{
    private string vorname = string.Empty;

    public string Vorname
    {
        get => vorname;
        set
        {
			if (value.Length < 3 || value.Length > 15)
				throw new Exception("Vorname muss zwischen 3 und 15 Zeichen haben!");

			if (!value.All(char.IsLetter))
				throw new Exception("Vorname darf nur aus Buchstaben bestehen!");

			vorname = value;
            Notify();
        }
    }

    private string nachname = string.Empty;

    public string Nachname
    {
        get => nachname;
        set
        {
            nachname = value;
            Notify();
        }
    }

    private DateTime gebDat = new DateTime(2000, 01, 01);

    public DateTime GebDat
    {
        get => gebDat;
        set
        {
            gebDat = value;
            Notify();
        }
    }

    private bool verheiratet;

    public bool Verheiratet
    {
        get => verheiratet;
        set
        {
            verheiratet = value;
            Notify();
        }
    }

    private Color lieblingsfarbe = new Color();

    public Color Lieblingsfarbe
    {
        get => lieblingsfarbe;
        set
        {
            lieblingsfarbe = value;
            Notify();
        }
    }

	//Kann ignoriert werden
	public string Error => throw new NotImplementedException();

	public string this[string propertyName]
	{
		get
		{
			//switch um das entsprechende Feld anzuschauen
			switch (propertyName)
			{
				case nameof(Nachname):
					if (Nachname.Length < 3 || Nachname.Length > 15)
						return "Nachname muss zwischen 3 und 15 Zeichen haben!"; //Über return werden die Fehlermeldungen zurück gegeben

					if (!Nachname.All(char.IsLetter))
						return "Nachname darf nur aus Buchstaben bestehen!";
					break;
			}

			//Kein Fehler: return null
			return null;
		}
	}


	public event PropertyChangedEventHandler? PropertyChanged;

    public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}