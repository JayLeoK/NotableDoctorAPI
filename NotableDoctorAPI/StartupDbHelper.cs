using System;
using NotableDoctorAPI.Controllers;
using NotableDoctorAPI.Models;

namespace NotableDoctorAPI
{
    public class StartupDbHelper
    {

        //HELPER TO SEED DATA AT STARTUP
        public async void SeedData(DoctorAppContext dbContext)
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
                    FirstName = "Johnny",
                    LastName = "Appleseed"
                },
            };

            foreach (var doctor in doctors)
            {
                dbContext.Doctors.Add(doctor);
                await dbContext.SaveChangesAsync();
            }


        }
    }
}

