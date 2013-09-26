using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Capstone.Infrastructure.Data;
using Capstone.Infrastructure.Data.EF;
using Capstone.Infrastructure.Data.Interface;
using Capstone.Infrastructure.Data.Repositories;
using Capstone.Infrastructure.Data.EF.Entities;

namespace Capstone.Application.Web.Base {
    public class BaseMasterPage : System.Web.UI.MasterPage {


        #region "Members"
        private IUnitOfWork _unitOfWork;
        private IProjectRepository _projectRepo;
        private IProjectBacklogRepository _projectBacklogRepo;
        private ISprintRepository _sprintsRepo;
        private IFeatures_BugsRepository _featureBugs;
        #endregion


        #region "Properties"
        public IUnitOfWork UnitOfWork {
            get {
                if ( _unitOfWork == null )
                    _unitOfWork = new UnitOfWork();
                return _unitOfWork;
            }
        }

        public IProjectBacklogRepository ProjectBacklogs {
            get {
                if ( _projectBacklogRepo == null )
                    _projectBacklogRepo = new ProjectBacklogRepository(UnitOfWork);
                return _projectBacklogRepo;
            }
        }

        public IProjectRepository Projects {
            get {
                if ( _projectRepo == null )
                    _projectRepo = new ProjectRepository(UnitOfWork);
                return _projectRepo;
            }
        }

        public ISprintRepository Sprints {
            get {
                if(_sprintsRepo == null)
                    _sprintsRepo = new SprintRepository(UnitOfWork);
                return _sprintsRepo;
            }
        }

        public IFeatures_BugsRepository FeaturesBugs {
            get {
                if ( _featureBugs == null )
                    _featureBugs = new Features_BugsRepository(UnitOfWork);
                return _featureBugs;
            }
        }
        #endregion


        public BaseMasterPage() {
            _unitOfWork = new UnitOfWork();
        }

    }
}