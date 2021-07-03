﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Projeto_WEB.Models;

namespace Projeto_WEB.Data
{
    public class Projeto_WEBContext : DbContext
    {
        public Projeto_WEBContext (DbContextOptions<Projeto_WEBContext> options)
            : base(options)
        {
        }

        public DbSet<Projeto_WEB.Models.Department> Department { get; set; }
    }
}