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
            /*
            var objaveIscemOa = new ObjavaIscemOa[]
            {
                new ObjavaIscemOa{Ime="Jure",Priimek="Oblak",Lokacija="Koper",DelovniCas="polni delovni čas / dopoldan",Opis="Potrebujem asistenta z izpitom za avto. Hodim v službo za polovični delovni čas. Potrebujem asistenta, ki me lahko vozi do službe, mi nudi spremstvo in pomoč pri jutranji osebni negi.",AvtorObjave="Jure Oblak",DatumObjave=DateTime.Parse("2023-01-02")},
                
            };

            context.ObjaveIscemOa.AddRange(objaveIscemOa);
            context.SaveChanges();

            */
        }
    }
}