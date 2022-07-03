using System;
using Microsoft.EntityFrameworkCore;

namespace NotableDoctorAPI.Models
{
    public class DoctorAppContext : DbContext
    {
        public DoctorAppContext(DbContextOptions<DoctorAppContext> options)
            : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }

    }
}

