//Classes
    public class Properties{

       //default constructor does not need to be declared 
       public Properties(){
        isEnrolled=true;
       }

       //properties
       public String FirstName{get;set;}
       public String LastName{get;set;}
       public byte Age{get{        
        return (byte)Math.Floor(DateTime.Now.Subtract(new DateTime(1999,5,4)).TotalDays/365d);
}}
       public bool isEnrolled{get;set;}

       public double Percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, {Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    