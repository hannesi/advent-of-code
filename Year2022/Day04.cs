namespace Year2022;

public class Day04
{
    private IEnumerable<IEnumerable<SectionAssignment>> _groupedSectionAssignments;
    private readonly struct SectionAssignment
    {
        public SectionAssignment(int from, int to)
        {
            From = from;
            To = to;
        }
        public int To { get; init; }
        public int From { get; init; }
    }

    public Day04(IEnumerable<string> input)
    {
        _groupedSectionAssignments = input.Select(line => line.Split(',').Select(ParseSectionAssignment));
    }

    private static SectionAssignment ParseSectionAssignment(string s)
    {
        var limits = s.Split('-');
        return new SectionAssignment(int.Parse(limits[0]), int.Parse(limits[1]));
    }

    private static bool OneSectionFullyContainsTheOther(IEnumerable<SectionAssignment> sections)
    {
        if (sections.Count() < 2) throw new Exception("Don't do such things right before christmas!");
        var a = sections.ElementAt(0);
        var b = sections.ElementAt(1);
        return a.From >= b.From && a.To <= b.To || a.From <= b.From && a.To >= b.To;
    }

    private static bool SectionsOverlap(IEnumerable<SectionAssignment> sections)
    {
        if (sections.Count() < 2) throw new Exception("Don't do such things right before christmas!");
        var a = sections.ElementAt(0);
        var b = sections.ElementAt(1);
        return a.From <= b.From && a.To >= b.From || b.From <= a.From && b.To >= a.From;
    }

    public object SolvePartOne()
    {
        return _groupedSectionAssignments.Where(OneSectionFullyContainsTheOther).Count();
    }

    public object SolvePartTwo()
    {
        return _groupedSectionAssignments.Where(SectionsOverlap).Count();
    }
}


public class Day04Tests
{
    private readonly Day04 _example = new Day04(File.ReadAllLines("Day04_example.txt"));
    private readonly Day04 _puzzle = new Day04(File.ReadAllLines("Day04_input.txt"));
    
    [Fact]
    public void SolvePartOneTest()
    {
        Assert.Equal(2, _example.SolvePartOne());
    }

    [Fact]
    public void SolvePartTwoTest()
    {
        Assert.Equal(4, _example.SolvePartTwo());
    }

    [Fact]
    public void SolutionPartOne()
    {
        Assert.Equal(532, _puzzle.SolvePartOne());
    }
    
    [Fact]
    public void SolutionPartTwo()
    {
        Assert.Equal(854, _puzzle.SolvePartTwo());
    }

}
