namespace Extention_Meeting_class;

internal class Meeting
{
    private string _fullname;
    private DateTime _begin;
    private DateTime _end;
    public string FullName { get { return _fullname; } set { _fullname = value; } }
    public DateTime Begin { get { return _begin; } set { _begin = value; } }
    public DateTime End { get { return _end; } set { _end = value; } }
    public Meeting(string fullName, DateTime begin, DateTime end)
    {
        FullName = fullName;
        Begin = begin;
        End = end;
    }
}

static class MeetingSchedule
{
    public static Meeting[] Meetings = new Meeting[0];

    public static void SetMeeting(string fullName, DateTime begin, DateTime end)
    {
        if (begin >= end)
        {
            throw new WrongDateIntervalException();
        }

        for (int i = 0; i < Meetings.Length; i++)
        {
            if ((begin > Meetings[i].Begin && begin < Meetings[i].End) || (end < Meetings[i].End && end > Meetings[i].Begin) || (begin <= Meetings[i].Begin && end >= Meetings[i].End))
            {
                throw new ReservedDateIntervalException();
            }
        }
        Array.Resize(ref Meetings, Meetings.Length + 1);
        Meetings[^1] = new Meeting(fullName, begin, end);
    }
}


internal class ReservedDateIntervalException : Exception
{
    public ReservedDateIntervalException() : base("bu meeting basqa meetingle toqqusur")
    {

    }
}

internal class WrongDateIntervalException : Exception
{
    public WrongDateIntervalException() : base("daxil etdiyiniz tarix yanlisdir")
    {

    }
}
