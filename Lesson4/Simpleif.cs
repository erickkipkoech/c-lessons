public class SimpleIf{
    public string CalculateMessage(){
        var outValue="";
        var seconds=DateTime.Now.Second;
        if(seconds%2==0 & seconds%3==0){
            return "Seconds are divisible by 2 or 3";
        }
        else if(seconds % 2 ==0){
            return "Seconds are divisible by 2";
        }else if(seconds % 3==0){
            return "Seconds are divisible by 3";
//Logical operators AND and OR

        }else if(seconds%5==0 | seconds%7==0){
            return "Seconds are dvisible by 5 or 7";
        }
        else{
           return "Seconds are neither divisible by 2 nor 3";
        }
   
    }

    
}

public class Orange{
public void MakeJuice(){
    Console.WriteLine("Make Orange juice");
}
}
public class Apple{
    public void MakePie(){
        Console.WriteLine("Make Pie");
    }
}