﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace OCM.Core.Data
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class OCMEntities : DbContext
    {
        public OCMEntities()
            : base("name=OCMEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<AddressInfo> AddressInfoList { get; set; }
        public DbSet<AuditLog> AuditLogs { get; set; }
        public DbSet<ChargePoint> ChargePoints { get; set; }
        public DbSet<ChargerType> ChargerTypes { get; set; }
        public DbSet<CheckinStatusType> CheckinStatusTypes { get; set; }
        public DbSet<ConnectionInfo> ConnectionInfoList { get; set; }
        public DbSet<ConnectionType> ConnectionTypes { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CurrentType> CurrentTypes { get; set; }
        public DbSet<DataProvider> DataProviders { get; set; }
        public DbSet<DataProviderStatusType> DataProviderStatusTypes { get; set; }
        public DbSet<DataType> DataTypes { get; set; }
        public DbSet<EditQueueItem> EditQueueItems { get; set; }
        public DbSet<EntityType> EntityTypes { get; set; }
        public DbSet<MetadataField> MetadataFields { get; set; }
        public DbSet<MetadataGroup> MetadataGroups { get; set; }
        public DbSet<MetadataValue> MetadataValues { get; set; }
        public DbSet<Operator> Operators { get; set; }
        public DbSet<StatusType> StatusTypes { get; set; }
        public DbSet<SubmissionStatusType> SubmissionStatusTypes { get; set; }
        public DbSet<SystemConfig> SystemConfigs { get; set; }
        public DbSet<UsageType> UsageTypes { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<UserComment> UserComments { get; set; }
        public DbSet<UserCommentType> UserCommentTypes { get; set; }
        public DbSet<MediaItem> MediaItems { get; set; }
    }
}