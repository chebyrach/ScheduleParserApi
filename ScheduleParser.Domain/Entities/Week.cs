namespace ScheduleParser.Domain.Entities;

public class Week
{
    public int Number { get; }

    private readonly List<Day> _days = new();
    public IReadOnlyCollection<Day> Days => _days;

    internal Week(int number)
    {
        Number = number;
    }

    public Day AddDay(DayOfWeek dayOfWeek)
    {
        var day = new Day(dayOfWeek);
        _days.Add(day);
        return day;
    }
}
