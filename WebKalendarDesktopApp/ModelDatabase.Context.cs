﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebKalendarDesktopApp
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebKalendarEntities : DbContext
    {
        public WebKalendarEntities()
            : base("name=WebKalendarEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Citanja> Citanja { get; set; }
        public virtual DbSet<Dan> Dan { get; set; }
        public virtual DbSet<Jezik> Jezik { get; set; }
        public virtual DbSet<Liturgijska_boja> Liturgijska_boja { get; set; }
        public virtual DbSet<Misa> Misa { get; set; }
        public virtual DbSet<Nepromjenjivi> Nepromjenjivi { get; set; }
        public virtual DbSet<Propriji> Propriji { get; set; }
        public virtual DbSet<Razina_slavlja> Razina_slavlja { get; set; }
        public virtual DbSet<Tekst> Tekst { get; set; }
        public virtual DbSet<Vrijeme_slavlja> Vrijeme_slavlja { get; set; }
        public virtual DbSet<Vrsta_slavlja> Vrsta_slavlja { get; set; }
        public virtual DbSet<Vrsta_teksta> Vrsta_teksta { get; set; }
    }
}
