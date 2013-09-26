using System;
using System.Threading;
using System.ServiceModel;
using System.Threading.Tasks;
using System.Collections.Generic;
using Capstone.Infrastructure.Data.EF.Entities;
using Capstone.Infrastructure.Data.Services;

namespace Capstone.Services.ShouldntBeHere
{
    [ServiceContract]
    public interface IApplicationService
    {
        [OperationContract]
        ServiceResponse<object> CreateFeatureBug(CreateFeatureBugRequest request);

        [OperationContract]
        ServiceResponse<object> CreateProject(CreateProjectRequest request);

        [OperationContract]
        ServiceResponse<object> CreateReleaseBacklog(CreateReleseBacklogRequest request);

        [OperationContract]
        ServiceResponse<object> CreateSprint(CreateSprintRequest request);

        [OperationContract]
        ServiceResponse<List<Features_Bugs>> GetFeaturesAndBugs(GetFeaturesAndBugsRequest request);

        [OperationContract]
        ServiceResponse<List<ProjectBacklog>> GetProjectBacklog(GetProjectBacklogRequest request);

        [OperationContract]
        ServiceResponse<List<Project>> GetProjects(GetProjectsRequest request);

        [OperationContract]
        ServiceResponse<List<ReleaseBacklog>> GetReleaseBacklog(GetReleaseBacklogRequest request);

        [OperationContract]
        ServiceResponse<List<Sprint>> GetSprints(GetSprintsRequest request);

        [OperationContract]
        ServiceResponse<object> UpdateFeaturesBugs(UpdateFeaturesBugsRequest request);

        [OperationContract]
        ServiceResponse<object> UpdateProject(UpdateProjectRequest request);

        [OperationContract]
        ServiceResponse<object> UpdateProjectBacklog(UpdateProjectBacklogRequest request);

        [OperationContract]
        ServiceResponse<object> UpdateReleaseBacklog(UpdateReleaseBacklogRequest request);

        [OperationContract]
        ServiceResponse<object> UpdateSprint(UpdateSprintRequest request);
    }
}
