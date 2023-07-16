//Classes
    public class OverloadingConstructors{

       //default constructor does not need to be declared 
       public OverloadingConstructors(string firstName,string lastName,byte age,double percentage,bool enrolled ){
this.FirstName=firstName;
this.LastName=lastName;
this.Age=age;
this.isEnrolled=enrolled;
this.Percentage=percentage;
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

 
    