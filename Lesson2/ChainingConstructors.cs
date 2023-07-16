//Classes
    public class ChainingConstructors{

       //default constructor does not need to be declared 
       public ChainingConstructors(){
        Console.WriteLine("Running parameterless constructor");
        isEnrolled=true;
        Age=23;
       }

       public ChainingConstructors(byte age):this()
       {
this.Age=age;
       }

       //properties
       public String FirstName{get;set;}
       public String LastName{get;set;}
       public byte Age{get;set;}
       public bool isEnrolled{get;set;}

       public double Percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, {Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    