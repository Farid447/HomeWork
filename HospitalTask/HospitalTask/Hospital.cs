namespace HospitalTask;

internal class Hospital
{
    List<Appointment> appointments = [];
    public void AddAppoinment(Appointment appointment)
    {
        appointments.Add(appointment);
    }
    public void EndAppoinment(int no)
    {
        if (appointments.Find(x => x.No == no) is null)
            Console.WriteLine("bele gorus movcud deyil");
        else
            appointments.Find(x => x.No == no).EndDate = DateTime.Now;
    }
    public Appointment GetAppointment(int no)
    {
        if(appointments.Find(x => x.No == no) is null)
            Console.WriteLine("bele gorus movcud deyil");

        return appointments.Find(x => x.No == no);
    }
    public List<Appointment> GetAllAppointments()
    {
        return appointments;
    }
    public List<Appointment> GetWeeklyAppointments()
    {
        return appointments.FindAll(x => DateTime.Now.AddDays(-7) < x.StartDate);
    }
    public List<Appointment> GetTodaysAppointments()
    {
        return appointments.FindAll(x => DateTime.Today < x.StartDate);
    }
    public List<Appointment> GetAllContinuingAppointments()
    {
        return appointments.FindAll(x => x.StartDate < DateTime.Now && DateTime.Now < x.EndDate);
    }
}
