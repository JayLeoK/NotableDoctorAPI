using System;
using NotableDoctorAPI.Controllers;
using NotableDoctorAPI.Models;

namespace NotableDoctorAPI
{
    public class StartupDbHelper
    {

        //HELPER TO SEED DATA AT STARTUP
        public async void SeedDoctorData(DoctorAppContext dbContext, IAppointmentRepository appointmentRepository)
        {
            //seed the following doctors
            Doctor[] doctors = {
                new Doctor()
                {
                    DoctorId = 1,
                    FirstName = "Johnny",
                    LastName = "Appleseed"
                },
                new Doctor()
                {
                    DoctorId = 2,
                    FirstName = "Daniel",
                    LastName = "Phantom"
                },
            };

            foreach (var doctor in doctors)
            {
                dbContext.Doctors.Add(doctor);
                await dbContext.SaveChangesAsync();
            }

            Patient[] patients = {
                new Patient()
                {
                    PatientId = 1,
                    FirstName = "Sammy",
                    LastName = "Sniffles"
                },
                new Patient()
                {
                    PatientId = 2,
                    FirstName = "David",
                    LastName = "Diseased"
                },
            };

            foreach (var patient in patients)
            {
                dbContext.Patients.Add(patient);
                await dbContext.SaveChangesAsync();
            }

            Appointment[] appointments =
            {
                new Appointment()
                {
                    AppointmentId = 1,
                    StartTime = new DateTime(2022, 7, 1, 4, 30, 00, DateTimeKind.Utc),
                    EndTime = new DateTime(2022, 7, 1, 4, 45, 00, DateTimeKind.Utc),
                    DoctorId = 1,
                    PatientId = 1,
                },
                new Appointment()
                {
                    AppointmentId = 2,
                    StartTime = new DateTime(2022, 7, 1, 5, 30, 00, DateTimeKind.Utc),
                    EndTime = new DateTime(2022, 7, 1, 5, 45, 00, DateTimeKind.Utc),
                    DoctorId = 1,
                    PatientId = 2,
                },
            };
            foreach (var appointment in appointments)
            {
                appointmentRepository.AddAppointment(appointment);
            }

        }
    }
}

