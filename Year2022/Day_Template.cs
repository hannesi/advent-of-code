namespace Year2022;

public class Dayxx
{
    public Dayxx(string[] input)
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
    private readonly Dayxx _example = new Dayxx(File.ReadAllLines("Dayxx_example.txt"));
    private readonly Dayxx _puzzle = new Dayxx(File.ReadAllLines("Dayxx_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(0, _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(0, _example.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(0, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(0, _puzzle.SolvePartTwo());
    }

}
