using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Media;

namespace M007;

public class Person : INotifyPropertyChanged
{
    private string vorname = string.Empty;

    public string Vorname
    {
        get => vorname;
        set
        {
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

    public event PropertyChangedEventHandler? PropertyChanged;

    public void Notify([CallerMemberName] string propertyName = "") => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
}