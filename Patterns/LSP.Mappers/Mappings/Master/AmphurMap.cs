using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Master
{
    using LSP.Models.Master;

    /// <summary>
    /// HasKey new { ID, LanguageID }
    /// </summary>
    public class AmphurMap
        : MasterBaseMap<Amphur>
    {
        public AmphurMap()
        {
            // Table
            this.ToTable("MST_AMPHUR");

            // Properties
            this.Property(m => m.ID)
                .HasColumnName("AMPHUR_ID");

            this.Property(m => m.ProvinceID)
                .HasColumnName("PROVINCE_ID");

            this.Property(m => m.Name)
                .HasColumnName("AMPHUR_NAME");

        }
    }
}
