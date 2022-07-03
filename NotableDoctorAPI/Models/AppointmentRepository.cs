using System;
using Microsoft.EntityFrameworkCore;

namespace NotableDoctorAPI.Models
{
    public class AppointmentRepository : IAppointmentRepository
    {
        private DoctorAppContext appContext;

        public AppointmentRepository(DoctorAppContext appContext)
        {
            this.appContext = appContext;
        }

        public async Task<Appointment> GetAppointment(long id)
        {
            return await appContext.Appointments.FindAsync(id);
        }

        public async Task<IEnumerable<Appointment>> GetAppointmentsByDoctorId(long doctorId)
        {
            return await appContext.Appointments.Where(a => a.DoctorId == doctorId).ToListAsync();
        }

        public async Task<Patient> GetPatientByAppointmentId(long appointmentId)
        {
            Appointment appt = await GetAppointment(appointmentId);

            return await appContext.Patients.Include("Appointments")
                .Where(p => p.PatientId == appt.PatientId).FirstOrDefaultAsync();
        }

        public async Task AddAppointment(Appointment appointment)
        {
            appContext.Appointments.Add(appointment);
            await appContext.SaveChangesAsync();
        }


    }
}

