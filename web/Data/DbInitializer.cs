using web.Models;
using web.Data;
using System;
using System.Linq;

namespace web.Data
{
    public static class DbInitializer
    {
        public static void Initialize(oaContext context)
        {
            context.Database.EnsureCreated();

            // Look for any students.
            if (context.UporabniskiRacuni.Any())
            {
                return;   // DB has been seeded
            }

            var uporabniskiRacuni = new UporabniskiRacun[]
            {
                new UporabniskiRacun{uporabniskoIme="Carson Alexander",eposta="carson@gmail.com",geslo="g1",EnrollmentDate=DateTime.Parse("2019-09-01")},
                new UporabniskiRacun{uporabniskoIme="Meredith Alonso",eposta="meredith@gmail.com",geslo="g2",EnrollmentDate=DateTime.Parse("2017-09-01")},
            };

            context.UporabniskiRacuni.AddRange(uporabniskiRacuni);
            context.SaveChanges();
        }
    }
}