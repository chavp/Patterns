using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Log
{
    using LSP.Models.Log;

    public abstract class LogBaseMap<T>
        : EntityTypeConfiguration<T> where T : LogBase
    {
        public LogBaseMap()
        {
            // Primary Key
            this.HasKey(m => m.ID);

            // Properties
            this.Property(m => m.ID)
                .HasColumnName("LOG_ID");

            this.Property(m => m.Type)
                .HasMaxLength(20)
                .HasColumnName("LOG_TYPE");

            this.Property(m => m.Dtm)
                .HasColumnName("LOG_DTM");

            this.Property(m => m.By)
                .HasMaxLength(50)
                .HasColumnName("LOG_BY");

            this.Property(m => m.Desc)
                .HasColumnName("LOG_DESC");

            this.Property(m => m.SystemName)
                .HasMaxLength(255)
                .HasColumnName("SYSTEM_NAME");

            this.Property(m => m.ModuleName)
                .HasMaxLength(255)
                .HasColumnName("MODULE_NAME");

            this.Property(m => m.SPName)
                .HasMaxLength(255)
                .HasColumnName("SP_NAME");

            this.Property(m => m.WebBrowser)
                .HasMaxLength(255)
                .HasColumnName("WEB_BROWSER");

            this.Property(m => m.ClientOS)
                .HasMaxLength(255)
                .HasColumnName("CLIENT_OS");

            this.Property(m => m.ClientIP)
                .HasMaxLength(30)
                .HasColumnName("CLIENT_IP");

            this.Property(m => m.ServerIP)
                .HasMaxLength(30)
                .HasColumnName("SERVER_IP");

            this.Property(m => m.MacIP)
                .HasMaxLength(30)
                .HasColumnName("MAC_IP");
        }
    }
}
