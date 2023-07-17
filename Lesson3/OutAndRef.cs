class OutAndRef{
    public bool Enroll(short year,out string studentId)
    {
        studentId="SERIKI1821";
        return true;
    }

    public void doSomething(ref int myValue){
        myValue++;
        Console.WriteLine("Inside of Dosomething there is: "+myValue);

    }

    public void Hello(ref string myName){
        myName=myName + " Jones";
        Console.WriteLine("Hello "+myName);

    }

    public void CalculateGrade(Grade g){
        g.FinalScore=0.9m;
    }

    //class reference
    public class Grade{
        public string NameOfClass{get;set;}
        public decimal FinalScore{get;set;}

    }
}