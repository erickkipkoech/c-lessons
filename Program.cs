
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
         }
    }


    
}