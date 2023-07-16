//Classes
    public class Student{

       //default constructor does not need to be declared 
       public Student(){
isEnrolled=true;
FirstName="Edmond";
LastName="Henry";
Age=30;
percentage=23.34;
       }

       //properties
       public String FirstName{get;set;}
       public String LastName{get;set;}
       public byte Age{get;set;}
       public bool isEnrolled{get;set;}

       public double percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, {Age}, Percentage:{percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    