using LesApp.Lib.Context;
using LesApp.Lib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LesApp0.CRUD
{
    /// <summary>
    /// Create one row
    /// </summary>
    internal class Create
    {
        internal Create(Audience audience, LesApp0Context db)
        {
            db.Entry(audience).State = EntityState.Added;
            
            // add
            db.Audiences.Add(audience);

            //save
            db.SaveChanges();
        }
    }
}
