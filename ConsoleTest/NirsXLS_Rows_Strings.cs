//*********************************************************************************
//
//
//
//  NirsXLS.cs
//
//*********************************************************************************
using LinqToExcel;
using System.Linq;
using System.ComponentModel;

[ExcelSheet(Name = "Анкета")]
public class NirsXLS_Rows_Strings : INotifyPropertyChanged
{

    private double _n;
    private string _анкета;
    private string _студент;

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void SendPropertyChanged(string propertyName)
    {
        PropertyChangedEventHandler handler = PropertyChanged;
        if (handler != null)
        {
            handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }


    [ExcelColumn(Name = "N", Storage = "_n")]
    public double N
    {
        get { return _n; }
        set
        {
            _n = value;
            SendPropertyChanged("N");
        }
    }

    [ExcelColumn(Name = "Анкета", Storage = "_анкета")]
    public string Анкета
    {
        get { return _анкета; }
        set
        {
            _анкета = value;
            SendPropertyChanged("Анкета");
        }
    }

    [ExcelColumn(Name = "Студент", Storage = "_студент")]
    public string Студент
    {
        get { return _студент; }
        set
        {
            _студент = value;
            SendPropertyChanged("Студент");
        }
    }
}
