﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ServiceSeekiosUnitTest
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class seekios_dbEntities : DbContext
    {
        public seekios_dbEntities()
            : base("name=seekios_dbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<user> user { get; set; }
        public virtual DbSet<seekiosProduction> seekiosProduction { get; set; }
        public virtual DbSet<device> device { get; set; }
        public virtual DbSet<versionApplication> versionApplication { get; set; }
        public virtual DbSet<operation> operation { get; set; }
        public virtual DbSet<operationFromStore> operationFromStore { get; set; }
        public virtual DbSet<packCredit> packCredit { get; set; }
        public virtual DbSet<versionEmbedded> versionEmbedded { get; set; }
        public virtual DbSet<alert> alert { get; set; }
        public virtual DbSet<location> location { get; set; }
        public virtual DbSet<mode> mode { get; set; }
        public virtual DbSet<seekios> seekios { get; set; }
        public virtual DbSet<token> token { get; set; }
    
        public virtual int DeleteUserByIDuser(string iduser)
        {
            var iduserParameter = iduser != null ?
                new ObjectParameter("iduser", iduser) :
                new ObjectParameter("iduser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteUserByIDuser", iduserParameter);
        }
    
        public virtual int DeleteModeById(Nullable<int> idMode, ObjectParameter result)
        {
            var idModeParameter = idMode.HasValue ?
                new ObjectParameter("IdMode", idMode) :
                new ObjectParameter("IdMode", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteModeById", idModeParameter, result);
        }
    
        public virtual int DeleteSeekiosById(Nullable<int> idSeekios, ObjectParameter result)
        {
            var idSeekiosParameter = idSeekios.HasValue ?
                new ObjectParameter("IdSeekios", idSeekios) :
                new ObjectParameter("IdSeekios", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("DeleteSeekiosById", idSeekiosParameter, result);
        }
    }
}
