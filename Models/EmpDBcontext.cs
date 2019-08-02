using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EmployeeApp.Models
{
    public class EmpDBcontext: DbContext
    {
        public DbSet<Emp> Emps { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Emp>().MapToStoredProcedures();
        //    base.OnModelCreating(modelBuilder);
        //}
    }
}