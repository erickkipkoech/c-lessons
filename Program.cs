
namespace HelloWorld
{
    class Program
    
    {
        static void Main(string[] args)
        {
            var myNumber=12m;
var yourNumber=16m;
DateTime now=new DateTime(2020,7,15,3,16,12);
            Console.WriteLine("Hello, World!");
            Console.WriteLine(myNumber-yourNumber);
            Console.WriteLine(myNumber/yourNumber);
            var myNumberType=myNumber.GetType();
            //date types
            var datetype=now.GetType();
            TimeSpan ThreeHours=TimeSpan.FromHours(3);
            Console.WriteLine(myNumberType);
            Console.WriteLine(now);
            Console.WriteLine(now.Day);
            Console.WriteLine(now.AddDays(7));
            Console.WriteLine(now.Add(ThreeHours));

            //datetimekind- used to indicate the kind property whether local time or utc
            var nowKind=now.Kind;
            Console.WriteLine(nowKind);

            DateTime tomorrow=new DateTime(2023,7,16,3,16,12,DateTimeKind.Utc);
            Console.WriteLine(tomorrow);
            Console.WriteLine(tomorrow.Kind);

            //Tuples can be used to group together related data elements in a lightweight structure
            (int,int) point=(1,2);
            Console.WriteLine(point);
            Console.WriteLine(point.Item1);

            (decimal latitude,decimal longitude) Nairobi=(-0.1234m,35.234m);
            Console.WriteLine(Nairobi);


            //create new student objects and assign them to the variable names
    var Erick=new Student();
    Erick.FirstName="Erick";   
    Erick.LastName="Kipkoech";
    Erick.Age=24;
    Erick.isEnrolled=true;
    Erick.percentage=10.1342;

    Console.WriteLine(Erick);

    var John=new Student();
    John.FirstName="John";
    John.LastName="Doe";
    John.Age=56;
    John.isEnrolled=false;
    John.percentage=23.43;

    Console.WriteLine(John);

    var Mike=new Student();
    Mike.Age=34;
    Mike.LastName="Phelan";
    Mike.FirstName="Mike";
    Mike.isEnrolled=true;
    Mike.percentage=90.1;

    Console.WriteLine(Mike);
//with constructor initialization
    var Jane=new Student();
    Jane.FirstName="Jane";
    Jane.LastName="Smith";
    Jane.Age=23;
    Jane.percentage=12.4;

    Console.WriteLine(Jane);

    var Edmond=new Student();
    Edmond.FirstName="ED";
     Console.WriteLine(Edmond);
       


        //overloading consrtuctors
        var daisy=new OverloadingConstructors("Daisy","Daisy",25,23.34,true);
        Console.WriteLine(daisy);

        var nick=new OverloadingConstructors("Nick","Martin",45,23.34,false);
        Console.WriteLine(nick);

        //chaining constructors
        var s=new ChainingConstructors(30);
        Console.WriteLine(s);

        //properties
        var r=new Properties();
        Console.WriteLine(r);

        //Using default values
        var defaults=new DefaultValues();
        Console.WriteLine(defaults);

        //using expression body definition and 
var e=new ExpressionBodyDefinition();
e.FirstName="Eli";
e.LastName="Malone";
Console.WriteLine(e);

//fields to assign flexible data
var f=new Fields(new DateTime(1999,4,5));
f.FirstName="Mark";
f.LastName="Mark";
Console.WriteLine(f);

//Encapsulation
var t=new Encapsulation("Erick","Fritz",new DateTime(1999,2,1));
t.FirstName="Liam";
t.isEnrolled=false;
t.BirthDate=new DateTime(1999,3,2);
Console.WriteLine(t);

//constants
var constant=new Constants("Leon","Jeffry",new DateTime(1992,2,3));
Console.WriteLine(constant);

//using record keyword
var d=new Records.StudentRecords("Fritz","Svl",23);
Console.WriteLine(d.ToString());

//Methods
var n=new Methods();
Console.WriteLine(n.CalculateGradesForClass("Quantam Physics"));

var g=new Methods.Grade();
Console.WriteLine(g);

//overloaded methods
var k=new Methods();
Console.WriteLine(k.CalculateGradesForClass("Quantam Physics"));

var l=new Methods();
Console.WriteLine(l.CalculateGradesForClass("Quantam Physics",2019));

//magic params parameter and optional parameters
var j=new Methods();
Console.WriteLine(j.CalculateGradePointAverage(2023,"Algebra","History","Geography","Maths","English","Programming"));

var m=new Methods();
Console.WriteLine(m.CalculateGradePointAverage(2019,"Art","History","Computer Science"));
Console.WriteLine(m.CalculateGradePointAverage(classes: new[] {"Algebra","Art","History","Computer Science"}));
Console.WriteLine(m.CalculateGradePointAverage());

// out and ref
var v=new OutAndRef();
string id="";
short year= (short)DateTime.Now.Year;
Console.WriteLine(v.Enroll(year,out id));
Console.WriteLine("student id: "+id);
Console.WriteLine("Year: "+year);

int myVar=2021;
v.doSomething(ref myVar);
Console.WriteLine("my var is "+myVar);

string myNamme="Doe";
v.Hello(ref myNamme);
Console.WriteLine(myNamme);

 //class reference
var o=new OutAndRef.Grade(){NameOfClass="Literature",FinalScore=0.7m};
Console.WriteLine(o.NameOfClass+" "+o.FinalScore);

v.CalculateGrade(o);
Console.WriteLine(o.NameOfClass+" "+o.FinalScore);

//delegates
var delegate_example=new CallBackFuncion();
var calHandler=new CallBackFuncion.CalculateHandler(delegate_example.Add);
delegate_example.Calculate(3,4,calHandler);

var calcHandler=new CallBackFuncion.CalculateHandler(delegate_example.Subtract);
delegate_example.Calculate(5,4,calcHandler);

//anonymous method addition
var multiply=new CallBackFuncion.CalculateHandler((foo,bar)=>foo*bar);
Console.WriteLine(delegate_example.Calculate(4,5,multiply));

var divide=new CallBackFuncion.CalculateHandler((foo,bar)=>foo/bar);
Console.WriteLine(delegate_example.Calculate(12,4,divide));

//direct call for a delegate
delegate_example.Calculate(34,21,delegate_example.Add);

//multicast delegation example
var calculation=new CallBackFuncion.CalculateHandler(delegate_example.Subtract);
calculation+=new CallBackFuncion.CalculateHandler(delegate_example.Add);
calculation+=new CallBackFuncion.CalculateHandler((arg1,arg2)=>{
var outMult=arg1*arg2;
Console.WriteLine("Multiplied: "+outMult);
return outMult;
});
calculation-=new CallBackFuncion.CalculateHandler(delegate_example.Subtract);
delegate_example.Calculate(2,9,calculation);

//ipmplementing a collection of delegates
delegate_example.Calculate(6,3,delegate_example.Add,delegate_example.Subtract);

//events
var event_example=new EnrolledEvents();
event_example.Enrolled+=(sender,args)=>Console.WriteLine("I am now enrolled for the year "+args.YearEnrolled);
event_example.Enroll();

//partial keyword


var partial_keyword=new Teacher {Name="Fritz",BirthDate=new DateTime(2000,2,4)};
Console.WriteLine(partial_keyword);
partial_keyword.displayAge();

//Enumerations
LightSwitch hall=LightSwitch.Bright;
Console.WriteLine(hall);

//to get the index of the enumeration
Console.WriteLine((int)LightSwitch.Off);

//enumeration constant call from a class
var enum_call=new Enrollment();
Console.WriteLine(enum_call.Enroll());

//flag enumerations
var flag_enum=FileAccess.Read | FileAccess.Write |FileAccess.Execute|FileAccess.Delete;
Console.WriteLine(flag_enum);

var weekdays=DaysOfWeek.Monday|DaysOfWeek.Tuesday|DaysOfWeek.Wednesday|DaysOfWeek.Thursday|DaysOfWeek.Friday|DaysOfWeek.Saturday|DaysOfWeek.Sunday;

Console.WriteLine(weekdays);

// simple if statement
var seconds=DateTime.Now.Second;
Console.WriteLine("Current seconds: "+seconds);
// if statement to check if second is divisible by 2 
if(seconds % 2==0){
    Console.WriteLine("Seconds are even");

}else{
    Console.WriteLine("Seconds are odd");
}

//optionally we can ommit curly braces but write the whole condition on one line(ending with a ; )
if (seconds % 2==0) Console.WriteLine("Seconds are even");
if (seconds % 2 !=0) Console.WriteLine("Seconds are odd");

    Console.WriteLine("This is outside the if statement");

//else,else if condition
if(seconds % 2==0) {Console.WriteLine("Seconds are even");}
else if(seconds % 3==0){Console.WriteLine("Seconds are a multiple of 3");}
else if(seconds % 5==0){Console.WriteLine("Seconds are a multiple of 5");}
else if(seconds%10==0){Console.WriteLine("Seconds are a multiple of 2,5 and 10");}
else{Console.WriteLine("Seconds are not divisible by 2,3,5 and 10");}

var display=new SimpleIf();
Console.WriteLine(display.CalculateMessage());
//conditional AND logical operator
bool MultipleOfThree(){
    Console.WriteLine("MultipleOfThree was called");
    return seconds%3==0;
}
if(seconds%2==0 && MultipleOfThree()){
    Console.WriteLine("Seconds are multiples of 2 and 3");
}
if (seconds!=null && seconds%2==1){
    Console.WriteLine("seconds are odd");
}

//conditional OR logical operator
if(seconds%2==0 || MultipleOfThree()){
    Console.WriteLine("Seconds are multiples of 2 0r 3");
}

//pattern matching using is
object fruit=new Apple();

if(fruit is Apple a){
a.MakePie();
}
else if(fruit is Orange or){
    or.MakeJuice();
}else{
    Console.WriteLine("I dont know what to use this fruit for");
}
//ternary conditional operators
var result= seconds%2==0 ? "seconds are even" :"seconds are odd";
Console.WriteLine(result);

//chained ternary conditional operators
//checker method
string CheckIfMultipleOfThree(int seconds){
    return seconds%3==0?"Even and Multiple of three":"Even";
}

result=seconds%2==0?CheckIfMultipleOfThree(seconds):"Odd";
Console.WriteLine(result);

var MultOfThree=seconds%3==0?"Even and Multiple of three":"Even";
Console.WriteLine(seconds%2==0?"Even and multiple of 3":"Odd");

//null coalescing operator ??
var coalescingValue="test";
Console.WriteLine(coalescingValue?? "It is null");

//null conditional operator ?

NullCondition test=new NullCondition{Name="Erick"};

Console.WriteLine("Our student name is "+test?.Name);
Console.WriteLine(test?.Hello());
Console.WriteLine("Our student name is: "+(test?.Name ?? "is not assigned yet" ));

//switch statement
var dayOfWeek=DateTime.Now.DayOfWeek;
dayOfWeek=DayOfWeek.Tuesday;
switch(dayOfWeek){
    case DayOfWeek.Monday: Console.WriteLine("Does somebody have a case of the Mondays?");
    break;
    case DayOfWeek.Tuesday: Console.WriteLine("It's TACO TUESDAY at the cafe!");
    break;
    case DayOfWeek.Wednesday: Console.WriteLine("Middle of the work-week... almost done!");
    break;
    case DayOfWeek.Thursday: Console.WriteLine("Friday is ALMOST HERE!!");
    break;
    case DayOfWeek.Friday: Console.WriteLine("The weekend starts.... NOW!");
    break;
    case DayOfWeek.Saturday: Console.WriteLine("Relaxing... no school, no work...");
    break;
    case DayOfWeek.Sunday: Console.WriteLine("School and work tomorrow?  Better have some fun NOW!");
    break;
    default: Console.WriteLine("I don't care what day of the week it is... we're on HOLIDAY!");
    break;
}
//switch expression
var message=dayOfWeek switch{
    DayOfWeek.Monday=>"I've got a case of the Mondays",
    DayOfWeek.Friday=>"It's FRI-YAY!!!",
    _=>"Its a boring day"
};

Console.WriteLine(message);
//for loops
for(var counter=0;counter<=5;counter++){
    Console.WriteLine("Counter now is: "+counter);
}
//infinite for loop
for (var counter=0;counter>=0;counter++){
    Console.WriteLine("On the road to infinity: "+counter);
//break statement
    if (counter==100) break;
}
//for each loops
string[] arrayNames=new string[] {"One","Two","Three","Four","Five","Six"};

foreach(var name in arrayNames){
    Console.WriteLine(name);
}
//foreach loop abouve is the same as 
for(var name=0;name<arrayNames.Length;name++){
    Console.WriteLine(arrayNames[name]);
}
//using foreach with reference types
var students=new Student[]{
    new Student{FirstName="Edmond"},
    new Student{FirstName="Eli"}
};
foreach(var student in students){
    Console.WriteLine("Name: "+student.FirstName);
//letters of each name
    foreach(var letters in student.FirstName){
        Console.WriteLine(letters);
    }
}
//do while loops
var Counter=4;
while(Counter<5){
    Counter++;
    Console.WriteLine(Counter);
}

do{
    Counter++;
    Console.WriteLine(Counter);
}while(Counter<5);
}
    }
    
}


