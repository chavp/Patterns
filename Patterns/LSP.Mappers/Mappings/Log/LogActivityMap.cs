using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity.ModelConfiguration;

namespace LSP.Mappers.Mappings.Log
{
    using LSP.Models.Master;
    using LSP.Models.Log;

    public class LogActivityMap
        : LogBaseMap<LogActivity>
    {
        public LogActivityMap()
        {
            // Table
            this.ToTable("SYS_LOG_ACTIVITY");

            // Properties
            this.Property(m => m.ResultStatus)
                .HasMaxLength(10)
                .HasColumnName("RESULT_STATUS");

            this.Property(m => m.ResultDesc)
                .HasColumnName("RESULT_DESC");

            this.Property(m => m.ProgName)
                .HasMaxLength(255)
                .HasColumnName("PROG_NAME");
        }
    }
}
