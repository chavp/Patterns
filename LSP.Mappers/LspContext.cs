using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace LSP.Mappers
{
    using LSP.Models.Log;
    using LSP.Models.Master;
    using LSP.Models.Sys;

    using LSP.Mappers.Mappings.Master;
    using LSP.Mappers.Mappings.Sys;
    using LSP.Mappers.Mappings.Log;
    using LSP.Models;
    using LSP.Models.Repositories.Master;
    using LSP.Models.Repositories.Sys;
    using LSP.Models.Repositories.Log;
    using LSP.Mappers.Repositories.Log;
    using LSP.Mappers.Repositories.Master;
    using LSP.Mappers.Repositories.Sys;

    public class LspContext
        : DbContext, IRepositoryContext
    {
        static LspContext()
        {
            Database.SetInitializer<LspContext>(null);
        }

        public LspContext() : base("Name=LspContext") { }
        public LspContext(string connection) : base(string.Format("Name={0}", connection)) { }

        // Log
        ILogActivityRepository _logActivitieRepo = null;
        ILogErrorRepository _logErrorRepo = null;

        // Master
        IAmphurRepository _amphurRepo = null;
        IProvinceRepository _provinceRepo = null;
        IStudyTypeRepository _studyTypeRepo = null;

        // Sys
        ILanguageRepository _languageRepo = null;

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Log
            modelBuilder.Configurations.Add(new LogActivityMap());
            modelBuilder.Configurations.Add(new LogErrorMap());

            // Master
            modelBuilder.Configurations.Add(new AmphurMap());
            modelBuilder.Configurations.Add(new ProvinceMap());
            modelBuilder.Configurations.Add(new StudyTypeMap());

            // System
            modelBuilder.Configurations.Add(new LanguageMap());
        }

        #region Log Repositories
        public ILogActivityRepository LogActivityRepository
        {
            get 
            { 
                if(_logActivitieRepo == null) 
                    _logActivitieRepo = new LogActivityRepository(this);

                return _logActivitieRepo;
            }
        }

        public ILogErrorRepository LogErrorRepository
        {
            get
            {
                if (_logErrorRepo == null)
                    _logErrorRepo = new LogErrorRepository(this);

                return _logErrorRepo;
            }
        }
        #endregion

        #region Master Repositories
        public IAmphurRepository AmphurRepository
        {
            get 
            {
                if (_amphurRepo == null)
                    _amphurRepo = new AmphurRepository(this);

                return _amphurRepo;
            }
        }

        public IProvinceRepository ProvinceRepository
        {
            get
            {
                if (_provinceRepo == null)
                    _provinceRepo = new ProvinceRepository(this);

                return _provinceRepo;
            }
        }

        public IStudyTypeRepository StudyTypeRepository
        {
            get 
            {
                if (_studyTypeRepo == null)
                    _studyTypeRepo = new StudyTypeRepository(this);

                return _studyTypeRepo;
            }
        }
        #endregion

        #region Master Sys
        public ILanguageRepository LanguageRepository
        {
            get
            {
                if (_languageRepo == null)
                    _languageRepo = new LanguageRepository(this);

                return _languageRepo;
            }
        }
        #endregion
    }
}
