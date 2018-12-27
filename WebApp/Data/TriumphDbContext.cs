﻿using System;
using Microsoft.EntityFrameworkCore;
using WebApp.Models;

namespace WebApp.Data
{     public class TriumphDbContext : DbContext     {         public TriumphDbContext(DbContextOptions<TriumphDbContext> options)             : base(options)         {         }

        //Base Level Entities
        public DbSet<Client> Clients { get; set; }         public DbSet<Project> Projects { get; set; }         public DbSet<Employee> Employees { get; set; }         public DbSet<Contact> Contacts { get; set; }
        public DbSet<ClientNotes> ClientNote { get; set; }     } 
 }