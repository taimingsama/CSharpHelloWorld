namespace CSharpHelloWorld;

public record StudentInfo(uint Id, string Name)
{
    public override string ToString()
    {
        return $"{nameof(Id)}: {Id}, {nameof(Name)}: {Name}";
    }
}