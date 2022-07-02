namespace NotableDoctorAPI.Models;

public class Appointment
{
    public long AppointmentId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public Doctor Doctor { get; set; }
    public Patient Patient { get; set; }
}

