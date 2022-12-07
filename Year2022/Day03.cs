namespace Year2022;

public class Day03
{
    public Day03(string input)
    {
    }


    public object SolvePartOne()
    {
        return 0;
    }

    public object SolvePartTwo()
    {
        return 0;
    }
}


public class Day03Tests
{
    private readonly Day03 _exampleDay = new Day03(File.ReadAllText("Day03_example.txt"));
    private readonly Day03 _puzzleDay = new Day03(File.ReadAllText("Day03_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(0, _exampleDay.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(0, _exampleDay.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(0, _puzzleDay.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(0, _puzzleDay.SolvePartTwo());
    }

}
