﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class epic_apiEntities : DbContext
    {
        public epic_apiEntities()
            : base("name=epic_apiEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Apps> Apps { get; set; }
        public virtual DbSet<Languages> Languages { get; set; }
        public virtual DbSet<Translations> Translations { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UserType> UserType { get; set; }
        public virtual DbSet<Votes> Votes { get; set; }
        public virtual DbSet<Words> Words { get; set; }
    }
}
