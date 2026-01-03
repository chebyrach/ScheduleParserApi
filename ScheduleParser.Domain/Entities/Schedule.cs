namespace ScheduleParser.Domain.Entities;

public class Schedule
{
    private readonly List<Group> _groups = new();
    public IReadOnlyCollection<Group> Groups => _groups;

    public Group AddGroup(string name)
    {
        var group = new Group(name);
        _groups.Add(group);
        return group;
    }
}
