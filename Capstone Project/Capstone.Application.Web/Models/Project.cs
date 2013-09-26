using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Application.Web.Models
{
    public class Project
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime CreationDate { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
    }

    public class Sprints
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int RelwaseBacklogId { get; set; }
    }

    public class ReleaseBacklogs
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int ProjectBacklogID { get; set; }
    }

    public class ProjectBacklog
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime FinishDate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
        public int ProjectId { get; set; }
    }

    public class FeaturesBugs
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public int SprintId { get; set; }
    }

    public class PermissionCategories
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }

    public class Permissions
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int CategoryId { get; set; }
    }

    public class UserProjectPermissions
    {
        public int ID { get; set; }
        public int ProjectId { get; set; }
        public int PermissionId { get; set; }
    }
}