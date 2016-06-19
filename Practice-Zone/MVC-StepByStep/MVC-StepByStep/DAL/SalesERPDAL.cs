using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVC_StepByStep.Models;

namespace MVC_StepByStep.DAL
{
    public class SalesERPDAL : DbContext
    {

        public SalesERPDAL() : base("_SalesERPDAL")
        { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().ToTable("TblEmployee");
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}