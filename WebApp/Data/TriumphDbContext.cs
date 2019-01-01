﻿using System;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;
using WebApp.ViewModel;

namespace WebApp.Data
{     public class TriumphDbContext : IdentityDbContext     {         public TriumphDbContext(DbContextOptions<TriumphDbContext> options)             : base(options)         {         }
        //Base Level Entities
        public DbSet<Client> Clients { get; set; }         public DbSet<Project> Projects { get; set; }         public DbSet<Employee> Employees { get; set; }         public DbSet<Contact> Contacts { get; set; }
        public DbSet<Note> Notes { get; set; }
    } 
 }