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
    public class ProvinceMap
        : MasterBaseMap<Province>
    {
        public ProvinceMap()
        {
            // Table
            this.ToTable("MST_PROVINCE");

            // Properties
            this.Property(m => m.ID)
                .HasColumnName("PROVINCE_ID");

            this.Property(m => m.RegionID)
                .HasColumnName("REGION_ID");

            this.Property(m => m.Name)
                .HasColumnName("PROVINCE_NAME");


        }
    }
}
