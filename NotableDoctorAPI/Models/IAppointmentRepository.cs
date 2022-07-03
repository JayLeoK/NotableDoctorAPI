using System;
namespace NotableDoctorAPI.Models
{
    public interface IAppointmentRepository
    {
        public Task<Appointment> GetAppointment(long id);
        public Task AddAppointment(Appointment appointment);
        public Task<IEnumerable<Appointment>> GetAppointmentsByDoctorId(long doctorId);
        public Task<Patient> GetPatientByAppointmentId(long id);

    }
}

