using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DataAccess;
using System.Web.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace Capstone.Application.Web.Models
{
    public static class Dataz
    {
        public static string conString = ConfigurationManager.ConnectionString["ApplicationServices"].ConnectionString;

        public static List<Project> GetProjects()
        {
            var cmd = new SqlCommand("sp_GetProjects");
            cmd.CommandType = CommandType.StoredProcedure;
            var result = SQLData.ExecuteReader<Project>(cmd, conString);

            if (result.Any())
            {
                return result.ToList();
            }
            return new List<Project>(0);
        }

        public static void CreateProject(string name, string status, string client)
        {
            var cmd = new SqlCommand("sp_CreateProject");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Name", name);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@client", client);
            SQLData.ExecuteQuery(cmd, conString);
        }

        public static void UpdateProject(int id, string name, string status, string client)
        {
            var cmd = new SqlCommand("sp_UpdateProject");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@client", client);
            SQLData.ExecuteQuery(cmd, conString);
        }

        public static List<Feature> GetFeaturesAndBugs()
        {
            var cmd = new SqlCommand("sp_GetFeaturesAndBugs");
            cmd.CommandType = CommandType.StoredProcedure;
            var result = SQLData.ExecuteReader<Feature>(cmd, conString);

            if (result.Any())
            {
                return result.ToList();
            }
            return new List<Feature>(0);
        }

        public static void CreateFeatureBug(int sprintId, string name, string descriptiom, string, type, string status, string comments)
        {
            var cmd = new SqlCommand("sp_CreateFeatureBug");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@sprintId", sprintId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@description", description);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@comments", comments);
            SQLData.ExecuteQuery(cmd, conString);
        }

        public static void UpdateFeatureBug(int id, string name, string desc, string type, string status, string comments)
        {
            var cmd = new SqlCommand("sp_UpdateFeaturesBugs");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@desc", desc);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@comments", comments);
            SQLData.ExecuteQuey(cmd, conString);
        }

        public static List<Sprint> GetSprints()
        {
            var cmd = new SqlCommand("sp_GetSprints");
            cmd.CommandType = CommandType.StoredProcedure;
            var result = SQLData.ExecuteQuery<Sprint>(cmd, conString);

            if (result.Any())
            {
                return result.ToList();
            }
            return new List<Sprint>(0);
        }

        public static void CreateSprint(int backLogId, int name, string type, string status, DateTime startDate)
        {
            var cmd = new SqlCommand("sp_CreateSprint");
            cmd.Parameters.AddWithValue("@releaseBacklogId", backLogId);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@startsDate", startDate);
            SQLData.ExecuteQuery(cmd, conString);
        }

        public static void UpdateSprint(int id, string name, string type, DateTime finishDate, string status, DateTime startDate)
        {
            var cmd = new SqlCommand("sp_UpdateSprint");
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@finishDate", finishDate);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            SQLDate.ExecuteQuery(cmd, conString);
        }

        public static List<Release> GetReleaseBacklog()
        {
            var cmd = new SqlCommand("sp_GetReleaseBacklog");
            cmd.CommandType = CommandType.StoredProcedure;
            var result = SQLData.ExecuteQuery<Release>(cmd, conString);

            if (result.Any())
            {
                return result.ToList();
            }
            return new List<Release>(0);
        }

        public static void CreateReleaseBacklog(int id, string name, string type, string status, DateTime startDate)
        {
            var cmd = new SqlCommand("sp_CreateReleaseBacklog");
            cmd.Parameters.AddWithValue("@projectBacklogID", id);
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@startDate", startDate);
        }

        public static void UpdateReleaseBacklog(string name, string type, DateTime finishDate, string status, DateTime startDate)
        {
            var cmd = new SqlCommand("sp_UpdateReleaseBacklog");
            cmd.Parameters.AddWithValue("@name", name);
            cmd.Parameters.AddWithValue("@type", type);
            cmd.Parameters.AddWithValue("@finishDate", finishDate);
            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@startDate", startDate);
            SQLData.ExecuteQuery(cmd, conString);
        }
    }
}