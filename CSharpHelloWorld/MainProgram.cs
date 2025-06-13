namespace CSharpHelloWorld;

public class MainProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        
        var student = new StudentInfo(1, "汰铭");

        Console.WriteLine(student);
    }
}