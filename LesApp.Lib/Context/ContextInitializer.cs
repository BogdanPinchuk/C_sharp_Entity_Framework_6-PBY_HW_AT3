using LesApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp.Lib.Context
{
    /// <summary>
    /// Ініціаолізатор БД
    /// </summary>
    public class ContextInitializer : DropCreateDatabaseAlways<LesApp0Context>
    {
        private readonly Random rnd = new Random();

        protected override void Seed(LesApp0Context db)
        {
            // create data
            Audience[] audiences = new Audience[10];

            for (int i = 0; i < audiences.Length; i++)
            {
                audiences[i] = new Audience()
                {
                    Number = 500 + i,
                    Category = ((char)rnd.Next(65, 91)).ToString(),
                    CountOfWorkPlace = rnd.Next(10, 36),
                    Id = i + 1,
                };
            }

            // save data
            db.Audiences.AddRange(audiences);
            db.SaveChanges();
        }

    }
}
