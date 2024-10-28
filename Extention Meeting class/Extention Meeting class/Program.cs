namespace Extention_Meeting_class;

internal class Program
{
    static void Main(string[] args)
    {
        MeetingSchedule.SetMeeting("Murad Cavadov", new DateTime(2024, 10, 28), new DateTime(2024, 10, 29));

        MeetingSchedule.SetMeeting("Revan Bayramov", new DateTime(2024, 10, 27), new DateTime(2024, 10, 28));

        MeetingSchedule.SetMeeting("Ferid Necefov", new DateTime(2024, 10, 27), new DateTime(2024, 10, 29));

    }
}
