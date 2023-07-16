//Classes
    public class ExpressionBodyDefinition{

       //default constructor does not need to be declared 
    //    public ExpressionBodyDefinition(){
    //    }

       //properties
       public String FirstName{get;set;}
       public String LastName{get;set;}

       public String Name=>$"{FirstName} {LastName}";
       public byte Age=>     
        (byte)Math.Floor(DateTime.Now.Subtract(new DateTime(1999,5,4)).TotalDays/365d);

       public bool isEnrolled=>true;

       public double Percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{Name}, {Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    