//Classes
    public class Constants{

        private string _firstName;
    private string _lastName;
    private DateTime _birthDate;

    private double _percentage;

    private bool _isEnrolled;

    public const double Total=23.34;

       //default constructor does not need to be declared 
       public Constants(string firstName, string lastName,DateTime birthDate){
        this.isEnrolled=true;
        this._firstName=firstName;
        this._lastName=lastName;
        this._percentage=12.3;
       }

       //properties
       
       public String FirstName{
        //encapsulate FirstName in _firstName
        get{
        return _firstName;
       }set{
        _firstName=value;
       }}
       public String LastName{get{
        return _lastName;
       }set{
        _lastName=value;
       }}

       public DateTime BirthDate{get{
        return _birthDate;
       }set{
        _birthDate=value;
       }}
       public byte Age{get{        
        return (byte)Math.Floor(DateTime.Now.Subtract(BirthDate).TotalDays/365d);
}}
       public bool isEnrolled{get{
        return _isEnrolled;}set{
_isEnrolled=value;
        }}

       public double Percentage{get{return _percentage;}set{
        _percentage=value;
       }}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, {Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled} and the constant totals is {Total}";
    }



    }

 
    