namespace Year2022;

public class Day06
{
    private readonly string _data;

    public Day06(string input)
    {
        _data = input;
    }

    private int GetPacketMarker(int distinctCount)
    {
        for (var i = 0; i < _data.Length; i++)
        {
            var ss = _data.Substring(i, distinctCount);
            if (ss.Distinct().Count().Equals(ss.Length))
            {
                return i + distinctCount;
            }
        }
        return 0;
    }

    public object SolvePartOne()
    {
        return GetPacketMarker(4);
    }

    public object SolvePartTwo()
    {
        return GetPacketMarker(14);
    }
}


public class Day06Tests
{
    private readonly string[] _exampleStrings = File.ReadAllLines("Day06_examples.txt");
    private readonly string[] _exampleStrings2 = File.ReadAllLines("Day06_examples2.txt");
    private readonly Day06 _puzzle = new Day06(File.ReadAllText("Day06_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        var examples = _exampleStrings.Select(s => new Day06(s)).ToArray();
        Assert.Equal(5, examples[0].SolvePartOne());
        Assert.Equal(6, examples[1].SolvePartOne());
        Assert.Equal(10, examples[2].SolvePartOne());
        Assert.Equal(11, examples[3].SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        var examples = _exampleStrings2.Select(s => new Day06(s)).ToArray();
        Assert.Equal(19, examples[0].SolvePartTwo());
        Assert.Equal(23, examples[1].SolvePartTwo());
        Assert.Equal(23, examples[2].SolvePartTwo());
        Assert.Equal(29, examples[3].SolvePartTwo());
        Assert.Equal(26, examples[4].SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(1300, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(3986, _puzzle.SolvePartTwo());
    }

}
