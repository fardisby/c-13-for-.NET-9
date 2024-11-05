Console.WriteLine("Hello, C# 13");

var subList = new DeveloperList("C#", ".NET 9");

foreach (var sub in subList.Devs)   
    Console.WriteLine(sub);

public class DeveloperList
{
    public IList<string> Devs { get; private set; }

    public DeveloperList(params List<string> devs)
    {
        Devs = devs;
    }
}
