using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Sys
{
    using LSP.Models.Sys;

    public class LanguageMap 
        : SystemBaseMap<Language>
    {
        public LanguageMap()
        {
            this.ToTable("SYS_LANGUAGE");

            // Primary Key
            this.HasKey(m => m.ID);

            // Properties
            this.Property(m => m.ID)
                .HasMaxLength(10)
                .HasColumnName("LANGUAGE_ID");

            this.Property(m => m.Abbreviation)
                .HasMaxLength(50)
                .HasColumnName("LANGUAGE_ABBR");

            this.Property(m => m.Name)
                .HasMaxLength(200)
                .HasColumnName("LANGUAGE_NAME");

            this.Property(m => m.Order)
                .HasColumnName("LANGUAGE_ORDER");

            this.Property(m => m.Collation)
                .HasMaxLength(50)
                .HasColumnName("LANGUAGE_COLLATION");

            this.Property(m => m.YearCulture)
                .HasMaxLength(10)
                .HasColumnName("YEAR_CULTURE");

            this.Property(m => m.YearCultureValue)
                .HasMaxLength(50)
                .HasColumnName("YEAR_CULTURE_VALUE");

            this.Property(m => m.DefaultLanguageFlag)
                .HasMaxLength(1)
                .HasColumnName("DEFAULT_LANGUAGE_FLAG");

            this.Property(m => m.ActiveFlag)
                .HasMaxLength(1)
                .HasColumnName("ACTIVE_FLAG");
        }
    }
}
