using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using Capstone.Infrastructure.Data.EF;
using Capstone.Infrastructure.Data.EF.Entities;
using Capstone.Infrastructure.Data.Repositories;
using Capstone.Infrastructure.Data.Services;
using Capstone.Services.ShouldntBeHere.DB;

namespace Capstone.Services.ShouldntBeHere
{
    public class ApplicationServiceBase : IApplicationService
    {
        public ServiceResponse<object> CreateFeatureBug(CreateFeatureBugRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                DataAccessor.ExecuteNonQuery("sp_CreateFeatureBug"
                                             , new SqlParameter("@sprintId", request.SprintID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@description", request.Description)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@comments", request.Comments));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in CreateFeatureBug: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> CreateProject(CreateProjectRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                DataAccessor.ExecuteNonQuery("sp_CreateProject"
                                             , new SqlParameter("@Name", request.Name)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@client", request.Client));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in CreateProject: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> CreateReleaseBacklog(CreateReleseBacklogRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                DataAccessor.ExecuteNonQuery("sp_CreateReleaseBacklog"
                                             , new SqlParameter("@projectBacklogID", request.ProjectBacklogID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@startDate", request.StartDate));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in CreateReleaseBacklog: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> CreateSprint(CreateSprintRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = "" };
            try
            {
                DataAccessor.ExecuteNonQuery("sp_CreateSprint"
                                             , new SqlParameter("@releaseBacklogId", request.ReleseBacklogID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@startDate", request.StartDate));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in CreateSprint: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<List<Features_Bugs>> GetFeaturesAndBugs(GetFeaturesAndBugsRequest request)
        {
            var response = new ServiceResponse<List<Features_Bugs>> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                response.Result = DataAccessor.RunProc<Features_Bugs>("sp_GetFeaturesAndBugs"
                                                                      , new SqlParameter("@sprintId", request.SprintID));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Result = new List<Features_Bugs>();
                response.ServiceMessage = "An exception occurred in GetFeaturesAndBugs: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<List<ProjectBacklog>> GetProjectBacklog(GetProjectBacklogRequest request)
        {
            var response = new ServiceResponse<List<ProjectBacklog>> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                response.Result = DataAccessor.RunProc<ProjectBacklog>("sp_GetProjectBacklog"
                                                                       , new SqlParameter("@projectId", request.ProjectID));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Result = new List<ProjectBacklog>();
                response.ServiceMessage = "An exception occurred in GetProjectBacklog: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<List<Project>> GetProjects(GetProjectsRequest request)
        {
            var response = new ServiceResponse<List<Project>> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                response.Result = DataAccessor.RunProc<Project>("sp_GetProjects");
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Result = new List<Project>();
                response.ServiceMessage = "An exception occurred in GetProjects: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<List<ReleaseBacklog>> GetReleaseBacklog(GetReleaseBacklogRequest request)
        {
            var response = new ServiceResponse<List<ReleaseBacklog>> {Time = DateTime.Now, ServiceMessage = "" };
            try
            {
                response.Result = DataAccessor.RunProc<ReleaseBacklog>("sp_GetReleaseBacklog"
                                                               , new SqlParameter("@backlogId", request.BacklogID));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Result = new List<ReleaseBacklog>();
                response.ServiceMessage = "An exception occurred in GetReleaseBacklog: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<List<Sprint>> GetSprints(GetSprintsRequest request)
        {
            var response = new ServiceResponse<List<Sprint>> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                response.Result = DataAccessor.RunProc<Sprint>("sp_GetSprints"
                                                               , new SqlParameter("@releaseBacklogId", request.ReleaseBacklogID));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.Result = new List<Sprint>();
                response.ServiceMessage = "An exception occurred in GetSprints: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> UpdateFeaturesBugs(UpdateFeaturesBugsRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = "" };
            try
            {
                DataAccessor.ExecuteNonQuery("sp_UpdateProject"
                                             , new SqlParameter("@id", request.ID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@desc", request.Desc)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@comments", request.Comments)
                                             , new SqlParameter("@developerId", request.DeveloperID));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in UpdateFeaturesBugs: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> UpdateProject(UpdateProjectRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = "" };
            try
            {
                DataAccessor.ExecuteNonQuery("sp_UpdateProject"
                                             , new SqlParameter("@id", request.ID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@client", request.Client));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in UpdateProject: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> UpdateProjectBacklog(UpdateProjectBacklogRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = "" };
            try
            {
                DataAccessor.ExecuteNonQuery("sp_UpdateProjectBacklog"
                                             , new SqlParameter("@id", request.ID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@finishDate", request.FinishDate)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@startDate", request.StartDate));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in UpdateProjectBacklog: " + ex.Message;    
            }
            return response;
        }

        public ServiceResponse<object> UpdateReleaseBacklog(UpdateReleaseBacklogRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                DataAccessor.ExecuteNonQuery("sp_UpdateReleaseBacklog"
                                             , new SqlParameter("@id", request.ID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@finishDate", request.FinishDate)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@startDate", request.StartDate));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in UpdateReleaseBacklog: " + ex.Message;
            }
            return response;
        }

        public ServiceResponse<object> UpdateSprint(UpdateSprintRequest request)
        {
            var response = new ServiceResponse<object> {Time = DateTime.Now, ServiceMessage = ""};
            try
            {
                DataAccessor.ExecuteNonQuery("sp_UpdateSprint"
                                             , new SqlParameter("@id", request.ID)
                                             , new SqlParameter("@name", request.Name)
                                             , new SqlParameter("@type", request.Type)
                                             , new SqlParameter("@finishDate", request.FinishDate)
                                             , new SqlParameter("@status", request.Status)
                                             , new SqlParameter("@startDate", request.Status)
                                             , new SqlParameter("@startDate", request.StartDate));
                response.IsSuccess = true;
            }
            catch (Exception ex)
            {
                response.IsSuccess = false;
                response.ServiceMessage = "An exception occurred in UpdateSprint: " + ex.Message;
            }
            return response;
        }
    }
}
