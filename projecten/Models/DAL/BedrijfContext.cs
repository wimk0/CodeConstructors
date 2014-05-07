﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;
using MySql.Data.Entity;
using projecten.Models.DAL.Mapper;
using projecten.Models.Domain;

namespace projecten.Models.DAL
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class BedrijfContext : DbContext
    {
        public BedrijfContext() :base("CodeConstructor")         
        {
            Database.SetInitializer<BedrijfContext>(new DropCreateDatabaseIfModelChanges<BedrijfContext>());
            //Database.SetInitializer<BedrijfContext>(new DropCreateDatabaseAlways<BedrijfContext>());
            //Database.Initialize(false);
        }

        public DbSet<StageOpdracht> StageOpdrachten { get; set; }
        public DbSet<Bedrijf> Bedrijven { get; set; }
        public DbSet<Student> studenten { get; set; }
        
        public DbSet<StageMentor> stagementors { get; set; }
        public DbSet<StageBegeleider> StageBegeleiders { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Configurations.Add(new BedrijfMapper());
            
            modelBuilder.Configurations.Add(new StageOpdrachtMapper());
            modelBuilder.Configurations.Add(new StudentMapper());
            modelBuilder.Configurations.Add(new StageBegeleiderMapper());
            modelBuilder.Configurations.Add(new StageMentorMapper());
          //  modelBuilder.Configurations.Add(new MigrationMapper());
           
        }
    }
}