namespace Year2022;

public class Day01
{
    private readonly List<int> _totalCaloriesPerElf;

    public Day01(string input)
    {
        _totalCaloriesPerElf = input.Split("\n\n", StringSplitOptions.RemoveEmptyEntries)
            .Select(block => block.Split("\n", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .Sum())
            .ToList();
    }


    public int SolvePartOne()
    {
        return _totalCaloriesPerElf.Max();
    }

    public int SolvePartTwo()
    {
        return _totalCaloriesPerElf.OrderByDescending(c => c).Take(3).Sum();
    }
}


public class Day01Tests
{
    private readonly Day01 _example = new Day01(File.ReadAllText("Day01_example.txt"));
    private readonly Day01 _puzzle = new Day01(File.ReadAllText("Day01_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(24000, _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(45000, _example.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(68923, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(200044, _puzzle.SolvePartTwo());
    }

}