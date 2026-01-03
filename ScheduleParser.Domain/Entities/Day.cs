namespace ScheduleParser.Domain.Entities;

public class Day
{
    public DayOfWeek DayOfWeek { get; }

    private readonly List<Lesson> _lessons = new();
    public IReadOnlyCollection<Lesson> Lessons => _lessons;

    internal Day(DayOfWeek dayOfWeek)
    {
        DayOfWeek = dayOfWeek;
    }

    public void AddLesson(
        string name,
        string teacher,
        string room,
        TimeOnly startTime,
        TimeOnly endTime)
    {
        var lesson = new Lesson(
            name,
            teacher,
            room,
            startTime,
            endTime);
        _lessons.Add(lesson);
    }
}
