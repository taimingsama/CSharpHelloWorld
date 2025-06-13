namespace CSharpHelloWorld;

public class MainProgram
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        var student = new StudentInfo(1, "汰铭");

        Console.WriteLine(student);

        var student2 = new StudentInfo(2, "小明");

        Console.WriteLine(student2);

        var teacher = new TeacherInfo(1, "枫野");

        Console.WriteLine(teacher);

        var teacher2 = new TeacherInfo(2, "小亮");

        Console.WriteLine(teacher2);
    }
}