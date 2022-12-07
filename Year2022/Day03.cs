namespace Year2022;

public class Day03
{
    private readonly string[] _data;

    public Day03(string[] input)
    {
        _data = input;
    }

    internal static int GetPriorityFromChar(char c)
    {
        if (char.IsUpper(c)) return c - 38;
        return c - 96;
    }

    private static Tuple<IEnumerable<char>, IEnumerable<char>> SplitToCompartments(string rucksack)
    {
        return Tuple.Create(rucksack.Take(rucksack.Length / 2), rucksack.Skip(rucksack.Length / 2).Take(rucksack.Length / 2));
    }

    private static char FindCommonCharacter(Tuple<IEnumerable<char>, IEnumerable<char>> compartments)
    {
        return compartments.Item1.Intersect(compartments.Item2).First();
    }
    
    public int SolvePartOne()
    {
        return _data.Select(SplitToCompartments).Select(FindCommonCharacter).Select(GetPriorityFromChar).Sum();
    }

    public object SolvePartTwo()
    {
        return _data.Chunk(3)
            .Select(chunk => chunk[0].Intersect(chunk[1]).Intersect(chunk[2]).First())
            .Select(GetPriorityFromChar)
            .Sum();
    }
}


public class Day03Tests
{
    private readonly Day03 _example = new Day03(File.ReadAllLines("Day03_example.txt"));
    private readonly Day03 _example2 = new Day03(File.ReadAllLines("Day03_example2.txt"));
    private readonly Day03 _puzzle = new Day03(File.ReadAllLines("Day03_input.txt"));

    [Fact]
    public void PriorityFromCharsTest()
    {
        Assert.Equal(1, Day03.GetPriorityFromChar('a'));
        Assert.Equal(26, Day03.GetPriorityFromChar('z'));
        Assert.Equal(27, Day03.GetPriorityFromChar('A'));
        Assert.Equal(52, Day03.GetPriorityFromChar('Z'));
    }
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(157, _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(70, _example2.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(8394, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(2413, _puzzle.SolvePartTwo());
    }
}
