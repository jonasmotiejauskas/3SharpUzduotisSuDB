﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace _3SharpUzduotisSuDB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KaraiIrMusiaiContainer : DbContext
    {
        public KaraiIrMusiaiContainer()
            : base("name=KaraiIrMusiaiContainer")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Karas> KarasSet { get; set; }
        public virtual DbSet<Musis> MusisSet { get; set; }
        public virtual DbSet<Valstybe> ValstybeSet { get; set; }
        public virtual DbSet<Karvedys> KarvedysSet { get; set; }
        public virtual DbSet<MusioDalyvis> MusioDalyvisSet { get; set; }
    }
}