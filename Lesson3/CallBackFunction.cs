class CallBackFuncion{
    public delegate int CalculateHandler(int Arg1,int Arg2);

    public int Calculate(int arg1,int arg2, CalculateHandler handler){
        var output=handler(arg1,arg2);
        return output;
    }

    public int Calculate(int arg1,int arg2,params CalculateHandler[] handlers){
        foreach(var handler in handlers){
            Console.WriteLine(handler(arg1,arg2));

        }
        return 0;
    }

    public int Add(int arg1,int arg2){
        var output=arg1+arg2;
        Console.WriteLine("Added: "+output);
        return output;
    }
    public int Subtract(int arg1,int arg2){
        var output=arg1-arg2;
        Console.WriteLine("Subtracted: "+output);
        return output;
    }
}