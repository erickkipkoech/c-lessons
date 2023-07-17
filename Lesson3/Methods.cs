class Methods{
    public void Enroll(){

    }

    internal void LeaveClassEarly(DateTime departureTime){

    }
    public decimal CalculateGradesForClass(string className){
        return 0.95m;
    }

    //overloading calcuulategradeforclass method
    public decimal CalculateGradesForClass(string className,int yearEnrolled){
        return 0.80m;
    }
//magic params parameter and optional parameters
    public decimal CalculateGradePointAverage(int yearOfStudy,params string[] classes){
        Console.WriteLine("This is the GPA for the year 2019");
        foreach(var c in classes){
            Console.WriteLine("Calculating for class "+c);
        }
        HelloWorld();
        return 0.90m;
    }

    //Overloading calculate gpa method
    public decimal CalculateGradePointAverage(short yearOfStudy=2020,params string[] classes){

        Console.WriteLine("This is the GPA for the year "+yearOfStudy);
        foreach(var c in classes){
            Console.WriteLine("Calculating for class "+c);
        }
        return 0.8m;
    }

        public decimal CalculateGradePointAverage(short yearOfStudy=0){
            if(yearOfStudy==0)  yearOfStudy=(short)DateTime.Now.Year;
        Console.WriteLine("This is the GPA for the year "+yearOfStudy);
      
        return CalculateGradePointAverage(yearOfStudy,"Art","Science","Physics","Engineering");
    }
    public void HelloWorld(){
        Console.WriteLine("Hello C# developers"); 
    }
    public class Grade{
        public string nameOfClass{
            get;set;
        }
    }
}