﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RefData
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RefEntities : DbContext
    {
        public RefEntities()
            : base("name=RefEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<BRON_ORG_REF> BRON_ORG_REF { get; set; }
        public DbSet<BRON_TYPE_REF> BRON_TYPE_REF { get; set; }
        public DbSet<CHECK_MONTH_REF> CHECK_MONTH_REF { get; set; }
        public DbSet<ECOMPENS_REF> ECOMPENS_REF { get; set; }
        public DbSet<EMOTOR_REF> EMOTOR_REF { get; set; }
        public DbSet<ENERNAGR_REF> ENERNAGR_REF { get; set; }
        public DbSet<ENERPRI_REF> ENERPRI_REF { get; set; }
        public DbSet<FACTORKZ_REF> FACTORKZ_REF { get; set; }
        public DbSet<MET_ISPOL_REF> MET_ISPOL_REF { get; set; }
        public DbSet<METER_REF> METER_REF { get; set; }
        public DbSet<NALOG_REF> NALOG_REF { get; set; }
        public DbSet<NALOGZ_REF> NALOGZ_REF { get; set; }
        public DbSet<POWMAX_REF> POWMAX_REF { get; set; }
        public DbSet<POWMAXZ_REF> POWMAXZ_REF { get; set; }
        public DbSet<PRECISE_REF> PRECISE_REF { get; set; }
        public DbSet<SETI_REF> SETI_REF { get; set; }
        public DbSet<TARPOPUL_REF> TARPOPUL_REF { get; set; }
        public DbSet<TRANSFPOWER> TRANSFPOWER { get; set; }
        public DbSet<TYPEHOUR_REF> TYPEHOUR_REF { get; set; }
        public DbSet<VID_EN_REF> VID_EN_REF { get; set; }
        public DbSet<WIRE_REF> WIRE_REF { get; set; }
        public DbSet<WIREZ_REF> WIREZ_REF { get; set; }
    }
}
