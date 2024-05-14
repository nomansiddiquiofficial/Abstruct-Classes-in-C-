

 abstract class Person
{
    public string name;
    public int age;
    public abstract void printdetails(string name, int age); 
    
}
class Student : Person
{
    public int rollNo;
    public double fees;
    public override void printdetails(string name , int age)
    {
        this.name = name;
        this.age = age;
        Console.WriteLine($"the name is: {name} and the age is :{age}");
    }
}


class Program
{
    public static void Main()
    {
        Student student = new Student();
        Person person = new Student(); // abstract he isliye Person ka object nhi banega tu child class ke through banwa rhe
        person.name = "Noman";
        person.age = 20;
        Console.WriteLine(person.name,person.age);

        student.rollNo = 15;
        student.fees = 3000;
        student.printdetails("Ali", 20);
        Console.WriteLine(student.rollNo);
        Console.WriteLine(student.fees);
    }
}