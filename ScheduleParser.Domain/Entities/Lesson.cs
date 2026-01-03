namespace ScheduleParser.Domain.Entities;

public class Lesson
{
    public string Name { get; }
    public string Teacher { get; }
    public string Room { get; }
    public TimeOnly StartTime { get; }
    public TimeOnly EndTime { get; }

    public Lesson(
        string name,
        string teacher,
        string room,
        TimeOnly startTime,
        TimeOnly endTime)
    {
        Name = name;
        Teacher = teacher;
        Room = room;
        StartTime = startTime;
        EndTime = endTime;
    }
}
