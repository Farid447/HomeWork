namespace HospitalTask;

internal class Program
{
    static void Main(string[] args)
    {
        Hospital hospital = new Hospital();

        Console.WriteLine("""

        1. Appointment yarat
        2. Appointmenti bitir
        3. Butun appointmentlere bax
        4. Bu hefteki appointmentlere bax
        5. Bugunki appointmentlere bax
        6. Bitmemis appointmentlere bax
        7. Menudan cix.

        """);
        int num = int.Parse(Console.ReadLine());
        while (num != 7)
        {
            switch (num)
            {
                case 1:
                    Console.WriteLine("Ad: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Doctor: ");
                    string doctor = Console.ReadLine();

                    Console.WriteLine("Gorusun baslama ili: ");
                    int il = int.Parse(Console.ReadLine());
                    
                    Console.WriteLine("Gorusun baslama ayi: ");
                    int ay = int.Parse(Console.ReadLine());

                    Console.WriteLine("Gorusun baslama gunu: ");
                    int gun = int.Parse(Console.ReadLine());

                    Console.WriteLine("Gorusun bitme ili: ");
                    int il2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Gorusun bitme ayi: ");
                    int ay2 = int.Parse(Console.ReadLine());

                    Console.WriteLine("Gorusun bitme gunu: ");
                    int gun2 = int.Parse(Console.ReadLine());

                    Appointment appointment = new Appointment(name, doctor, new DateTime(il, ay, gun), new DateTime(il2, ay2, gun2));
                    hospital.AddAppoinment(appointment);
                    Console.WriteLine("gorus elave olundu");
                    break;
                case 2:
                    Console.WriteLine("gorus nomresi daxil edin");
                    int no = int.Parse(Console.ReadLine());
                    hospital.EndAppoinment(no);
                    break;
                case 3:
                    foreach (var item in hospital.GetAllAppointments())
                    {
                        Console.WriteLine("No: " + item.No + "   xeste: " + item.Patient + "   hekim: " + item.Doctor + "   baslama vaxti: " + item.StartDate + "   bitme vaxti: " + item.EndDate);
                    };
                    break;
                case 4:
                    foreach (var item in hospital.GetWeeklyAppointments())
                    {
                        Console.WriteLine("No: " + item.No + "   xeste: " + item.Patient + "   hekim: " + item.Doctor + "   baslama vaxti: " + item.StartDate + "   bitme vaxti: " + item.EndDate);
                    };
                    break;
                case 5:
                    foreach (var item in hospital.GetTodaysAppointments())
                    {
                        Console.WriteLine("No: " + item.No + "   xeste: " + item.Patient + "   hekim: " + item.Doctor + "   baslama vaxti: " + item.StartDate + "   bitme vaxti: " + item.EndDate);
                    };
                    break;
                case 6:
                    foreach (var item in hospital.GetAllContinuingAppointments())
                    {
                        Console.WriteLine("No: " + item.No + "   xeste: " + item.Patient + "   hekim: " + item.Doctor + "   baslama vaxti: " + item.StartDate + "   bitme vaxti: " + item.EndDate);
                    };
                    break;
                default:
                    Console.WriteLine("duzgun eded daxil edin");
                    Console.WriteLine("""

                        1. Appointment yarat
                        2. Appointmenti bitir
                        3. Butun appointmentlere bax
                        4. Bu hefteki appointmentlere bax
                        5. Bugunki appointmentlere bax
                        6. Bitmemis appointmentlere bax
                        7. Menudan cix.

                        """);
                    break;
            }
            num = int.Parse(Console.ReadLine());
        }
    }
}