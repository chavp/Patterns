using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Master
{
    using LSP.Models.Master;

    public abstract class MasterBaseMap<T>
        : EntityTypeConfiguration<T> where T : MasterBase
    {
        public MasterBaseMap()
        {
            // Primary Key
            this.HasKey(t => t.RecordID);

            // Properties
            this.Property(t => t.RecordID)
                .HasColumnName("RECORD_ID");

            this.Property(t => t.LanguageID)
                .HasMaxLength(10)
                .HasColumnName("LANGUAGE_ID");

            this.Property(t => t.ActiveFlag)
                .HasMaxLength(1)
                .HasColumnName("ACTIVE_FLAG");

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
