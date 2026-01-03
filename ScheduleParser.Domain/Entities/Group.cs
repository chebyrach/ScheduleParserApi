namespace ScheduleParser.Domain.Entities;

public class Group
{
    public string Name { get; }

    private readonly List<Week> _weeks = new();
    public IReadOnlyCollection<Week> Weeks => _weeks;

    internal Group(string name)
    {
        Name = name;
    }

    public Week AddWeek(int number)
    {
        var week = new Week(number);
        _weeks.Add(week);
        return week;
    }
}
