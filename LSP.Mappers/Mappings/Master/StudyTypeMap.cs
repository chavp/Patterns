using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Master
{
    using LSP.Models.Master;

    /// <summary>
    /// HasKey new { ID, LanguageID }
    /// </summary
    public class StudyTypeMap 
        : MasterBaseMap<StudyType>
    {
        public StudyTypeMap()
        {
            // Table
            this.ToTable("MST_STUDY_TYPE");

            // Properties
            this.Property(m => m.ID)
                .HasColumnName("STUDY_TYPE_ID");

            this.Property(m => m.Name)
                .HasMaxLength(200)
                .HasColumnName("STUDY_TYPE_NAME");

            this.Property(m => m.Order)
                .HasColumnName("STUDY_TYPE_ORDER");
        }
    }
}
