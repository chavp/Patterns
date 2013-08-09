using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LSP.Models.Repositories.Sys
{
    using LSP.Models.Sys;

    public interface ILanguageRepository
        : IRepository<Language>
    {
        IEnumerable<Language> GetActiveLanguage();
    }
}
