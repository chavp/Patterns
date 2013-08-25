using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace LSP.Mappers.Mappings.Sys
{
    using LSP.Models.Sys;
    
    public abstract class SystemBaseMap<T>
        : EntityTypeConfiguration<T> where T : SystemBase
    {
        public SystemBaseMap()
        {
            // Properties
            this.Property(t => t.CreateDtm)
                .HasColumnName("CREATE_DTM");

            this.Property(t => t.CreateBy)
                .HasMaxLength(50)
                .HasColumnName("CREATE_BY");

            this.Property(t => t.UpdateDtm)
                .HasColumnName("UPDATE_DTM");

            this.Property(t => t.UpdateBy)
                .HasMaxLength(50)
                .HasColumnName("UPDATE_BY");

            this.Property(t => t.ProgramID)
                .HasMaxLength(50)
                .HasColumnName("PROGRAM_ID");

            this.Property(t => t.IPAddress)
                .HasMaxLength(30)
                .HasColumnName("IP_ADDRESS");

            this.Property(t => t.MacAddress)
                .HasMaxLength(30)
                .HasColumnName("MAC_ADDRESS");

        }
    }
}
