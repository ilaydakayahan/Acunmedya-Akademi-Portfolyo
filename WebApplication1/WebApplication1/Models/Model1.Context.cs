﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DbDominicPortfolioEntities : DbContext
    {
        public DbDominicPortfolioEntities()
            : base("name=DbDominicPortfolioEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TblCategory> TblCategories { get; set; }
        public virtual DbSet<TblProject> TblProjects { get; set; }
        public virtual DbSet<TblAbout> TblAbouts { get; set; }
        public virtual DbSet<TblFeature> TblFeatures { get; set; }
        public virtual DbSet<TblService> TblServices { get; set; }
        public virtual DbSet<TblTestimonial> TblTestimonials { get; set; }
        public virtual DbSet<TblContact> TblContacts { get; set; }
    }
}
