namespace Year2022;

public class Day02
{
    private enum Shape
    {
        Rock,
        Paper,
        Scissors
    }

    private enum Outcome
    {
        Draw,
        Loss,
        Win
    }

    private string[] _data;
    public Day02(string[] input)
    {
        _data = input;
    }

    private Shape ParseShapeFromChar(char c)
    {
        return c switch
        {
            'A' or 'X' => Shape.Rock,
            'B' or 'Y' => Shape.Paper,
            'C' or 'Z' => Shape.Scissors,
            _ => throw new ArgumentOutOfRangeException(nameof(c), c, null)
        };
    }

    private Tuple<Shape, Shape> ParseShapesFromString(string s)
    {
        return Tuple.Create(ParseShapeFromChar(s[0]), ParseShapeFromChar(s[2]));
    }

    private int ScoreRound(Tuple<Shape, Shape> shapes)
    {
        var points = (int)shapes.Item2 + 1;
        var outcome = (Outcome)(((int)shapes.Item1 - (int)shapes.Item2 + 3) % 3);
        return outcome switch
        {
            Outcome.Loss => points,
            Outcome.Draw => points + 3,
            Outcome.Win => points + 6,
            _ => throw new ArgumentOutOfRangeException()
        };
    }
    
    public int SolvePartOne()
    {
        return _data.Select(ParseShapesFromString)
            .Select(ScoreRound)
            .Sum();
    }

    private Tuple<Shape, Shape> ParseShapesFromStringAccordingToTheElvesFurtherAdvice(string s)
    {
        var opponentShape = ParseShapeFromChar(s[0]);
        var ownShape = s[2] switch
        {
            'X' => (Shape)(((int)opponentShape + 2) % 3),
            'Y' => opponentShape,
            'Z' => (Shape)(((int)opponentShape + 1) % 3),
            _ => throw new ArgumentOutOfRangeException()
        };
        return Tuple.Create(opponentShape, ownShape);
    }
    
    public int SolvePartTwo()
    {
        return _data.Select(ParseShapesFromStringAccordingToTheElvesFurtherAdvice).Select(ScoreRound).Sum();
    }
}


public class Day02Tests
{
    private readonly Day02 _example = new Day02(File.ReadAllLines("Day02_example.txt"));
    private readonly Day02 _puzzle = new Day02(File.ReadAllLines("Day02_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(15, _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(12, _example.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    { 
        Assert.Equal(12645, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(11756, _puzzle.SolvePartTwo());
    }

}
