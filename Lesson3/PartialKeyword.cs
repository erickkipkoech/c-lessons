public partial class Teacher{
    public string Name{get;set;}

    public void displayAge(){
        GetAge();
    }
    partial void GetAge();
}

public partial class Teacher{
    private DateTime _BirthDate;
    public DateTime BirthDate{
        get{return _BirthDate;}
        set{_BirthDate=value;}

    }
    partial void GetAge()
    {
Console.WriteLine("Get Age: "+(int)DateTime.Now.Subtract(_BirthDate).TotalDays/365);    }
}