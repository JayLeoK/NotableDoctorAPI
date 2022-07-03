namespace NotableDoctorAPI.Models;

public class Appointment
{
    public long AppointmentId { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; }
    public long DoctorId { get; set; }
    public long PatientId { get; set; }
    public Patient Patient { get; set; }
}

