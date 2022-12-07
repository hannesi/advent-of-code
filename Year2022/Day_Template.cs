namespace Year2022;

public class Dayxx
{
    public Dayxx(string input)
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


public class DayxxTests
{
    private readonly Dayxx _exampleDay = new Dayxx(File.ReadAllText("Dayxx_example.txt"));
    private readonly Dayxx _puzzleDay = new Dayxx(File.ReadAllText("Dayxx_input.txt"));
    
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
