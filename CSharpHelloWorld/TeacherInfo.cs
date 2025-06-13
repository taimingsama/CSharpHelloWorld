namespace CSharpHelloWorld;

public record TeacherInfo(uint Id, string Name)
{
    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
    }
}
