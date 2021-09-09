﻿using Microsoft.EntityFrameworkCore;
using MVCBasics.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCBasics.Repository
{
    public class PeopleContext:DbContext
    {
        public PeopleContext():base()
        {

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            ///<summary>
            ///Use Below Connection For Remote Database
            ///</summary>
            //optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=PeopleDB;Trusted_Connection=True;");
            ///<summary>
            ///Use Below Connection For Local Database
            ///</summary>
            optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=aspnet-MVCBasics;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
        public DbSet<Person> People { get; set; }
    }
}
