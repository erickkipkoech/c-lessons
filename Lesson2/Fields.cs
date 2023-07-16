//Classes
    public class Fields{

        private DateTime _birthDate;

        public Fields(DateTime birthDate){
            this._birthDate=birthDate;

        }

       //default constructor does not need to be declared 
       public Fields(){
        isEnrolled=true;
       }

       //properties
       public String FirstName{get;set;}
       public String LastName{get;set;}

       public DateTime BirthDate=>_birthDate;
       public byte Age{get{        
        return (byte)Math.Floor(DateTime.Now.Subtract(BirthDate).TotalDays/365d);
}}
       public bool isEnrolled{get;set;}

       public double Percentage{get;set;}


    public override string ToString()
    {
        return $"Name:{FirstName} {LastName}, BirthDate:{BirthDate},{Age}, Percentage:{Percentage}, Enrollment Status:{isEnrolled}";
    }



    }

 
    