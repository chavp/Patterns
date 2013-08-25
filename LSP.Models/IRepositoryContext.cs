using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models
{
    using LSP.Models.Repositories.Log;
    using LSP.Models.Repositories.Master;
    using LSP.Models.Repositories.Sys;

    public interface IRepositoryContext : IUnitOfWork
    {
        // Log
        ILogActivityRepository LogActivityRepository { get; }
        ILogErrorRepository LogErrorRepository { get; }

        // Master
        IAmphurRepository AmphurRepository { get; }
        IProvinceRepository ProvinceRepository { get; }
        IStudyTypeRepository StudyTypeRepository { get; }

        // Sys
        ILanguageRepository LanguageRepository { get; }
    }
}
