namespace Year2022;

public class Day04
{
    public Day04(string input)
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


public class Day04Tests
{
    private readonly Day04 _example = new Day04(File.ReadAllText("Day04_example.txt"));
    private readonly Day04 _puzzle = new Day04(File.ReadAllText("Day04_input.txt"));
    
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
