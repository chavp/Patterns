using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Mappers.Mappings.Log
{
    using LSP.Models.Log;

    public class LogErrorMap
        : LogBaseMap<LogError>
    {
        public LogErrorMap()
        {
            // Table
            this.ToTable("SYS_LOG_ERROR");

            // Properties
            this.Property(m => m.ApplicationName)
                .HasMaxLength(255)
                .HasColumnName("APPLICATION_NAME");

            this.Property(m => m.FunctionName)
                .HasMaxLength(255)
                .HasColumnName("FUNCTION_NAME");

            this.Property(m => m.SrcFileName)
                .HasMaxLength(255)
                .HasColumnName("SRC_FILE_NAME");

            this.Property(m => m.StackTrace)
                .HasColumnName("STACK_TRACE");
        }
    }
}
