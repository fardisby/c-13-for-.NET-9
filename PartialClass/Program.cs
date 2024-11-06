Console.WriteLine("Hello, C# 13");

var voteCounter = new VoteCounter();

voteCounter.Votes = 10;
Console.WriteLine(voteCounter.Votes);

public partial class VoteCounter
{
    public partial int Votes { get; set; }
}

public partial class VoteCounter
{
    private int _votes = 0;

    public partial int Votes
    {
        get { return _votes; }
        set { _votes = value; }
    }
}
