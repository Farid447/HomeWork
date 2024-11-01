namespace HospitalTask;

internal class Appointment
{
    private static int _no;
    public int No { get { return _no; } init { } }
    public string Patient { get; set; }
    public string Doctor { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Appointment(string patient, string doctor, DateTime startDate, DateTime endDate)
    {
        No = ++_no;
        Patient = patient;
        Doctor = doctor;
        StartDate = startDate;
        EndDate = endDate;
    }
}
