﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebSeries.EntityFramework
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WebSeries_DBEntities : DbContext
    {
        public WebSeries_DBEntities()
            : base("name=WebSeries_DBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
<<<<<<<< HEAD:WebSeries/EntityFramework/WebSeries_DB.Context.cs
        public virtual DbSet<User> Users { get; set; }
========
        public virtual DbSet<Archive> Archives { get; set; }
        public virtual DbSet<Expans> Expanses { get; set; }
        public virtual DbSet<Login> Logins { get; set; }
        public virtual DbSet<PackageAdmin> PackageAdmins { get; set; }
        public virtual DbSet<Package> Packages { get; set; }
        public virtual DbSet<Salary> Salarys { get; set; }
        public virtual DbSet<Session> Sessions { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Video> Videos { get; set; }
>>>>>>>> master:WebSeries/EntityFramework/WebSeriseDB.Context.cs
    }
}
