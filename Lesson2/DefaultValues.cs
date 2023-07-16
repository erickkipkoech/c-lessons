//Classes
    public class DefaultValues{

       //default constructor does not need to be declared 
       public DefaultValues(){
       }

       //properties
       public String FirstName{get;set;}="Michael";
       public String LastName{get;set;}
       public byte Age{get;set;}=30;
       public bool isEnrolled{get;set;}=false;

       public double Percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, {Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    