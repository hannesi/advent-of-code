namespace Year2022;

public class Day05
{
    private List<Stack<char>> _stacks;
    private List<(int Amount, int From, int To)> _instructions;
    public Day05(string input)
    {
        var stackString = input.Split("\n\n")[0];
        var instructionString = input.Split("\n\n")[1];

        GenerateStacks(stackString);
        GenerateInstructions(instructionString);
    }

    private void GenerateStacks(string stackString)
    {
        _stacks = new List<Stack<char>>();
        // generate an empty stack for each of the numbers below the stacks
        foreach (var s in stackString.Split("\n").Last().Split(' ', StringSplitOptions.RemoveEmptyEntries))
        {
            _stacks.Add(new Stack<char>());
        }

        foreach (var s in stackString.Split("\n").Reverse().Skip(1))
        {
            for (var i = 0; i < _stacks.Count; i++)
            {
                var c = s.ElementAtOrDefault(4 * i + 1);
                if (c != ' ') _stacks[i].Push(c);
            }
        }
    }

    private void GenerateInstructions(string instructionString)
    {
        _instructions = new List<(int Amount, int From, int To)>();
        foreach (var s in instructionString.Split("\n", StringSplitOptions.RemoveEmptyEntries))
        {
            _instructions.Add(ParseInstruction(s));
        }
    }

    private static (int Amount, int From, int To) ParseInstruction(string s)
    {
        var ss = s.Split(' ');
        return (int.Parse(ss[1]), int.Parse(ss[3]), int.Parse(ss[5]));
    }

    private void RunInstructions()
    {
        foreach (var instruction in _instructions)
        {
            for (var i = 0; i < instruction.Amount; i++)
            {
                _stacks.ElementAt(instruction.To - 1).Push(_stacks.ElementAt(instruction.From - 1).Pop());
            }
        }
    }

    private void RunInstructionsOnCrateMover9001()
    {
        var crateMover9001CraneHandThing = new Stack<char>();
        foreach (var instruction in _instructions)
        {
            for (var i = 0; i < instruction.Amount; i++)
            {
                crateMover9001CraneHandThing.Push(_stacks.ElementAt(instruction.From - 1).Pop());
            }

            while (crateMover9001CraneHandThing.Count > 0)
            {
                _stacks.ElementAt(instruction.To - 1).Push(crateMover9001CraneHandThing.Pop());
            }
        }
    }
    
    public string SolvePartOne()
    {
        RunInstructions();
        return string.Join("", _stacks.Select(s => s.Peek()));
    }

    public string SolvePartTwo()
    {
        RunInstructionsOnCrateMover9001();
        return string.Join("", _stacks.Select(s => s.Peek()));
    }
}


public class Day05Tests
{
    private readonly Day05 _example = new Day05(File.ReadAllText("Day05_example.txt"));
    private readonly Day05 _puzzle = new Day05(File.ReadAllText("Day05_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal("CMZ", _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal("MCD", _example.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal("ZSQVCCJLL", _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal("QZFJRWHGS", _puzzle.SolvePartTwo());
    }

}
