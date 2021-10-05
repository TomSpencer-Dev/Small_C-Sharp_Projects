﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Entity;
using CodeFirst;

namespace EF6Console
{
    public class SchoolContext: DbContext
    {
        public SchoolContext() : base()
        {

        }

        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }

    }
}
