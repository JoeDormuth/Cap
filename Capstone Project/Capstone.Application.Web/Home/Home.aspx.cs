using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System.Web.UI.WebControls;
using Capstone.Application.Web.Models;

namespace Capstone.Application.Web.Home
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Membership.CreateUser("", "", "");
           // Roles.AddUsersToRole(
            //Roles.CreateRole("Scrum Master");
            //Roles.CreateRole("Project Manager");
            //Roles.CreateRole("Developer");
            //Roles.CreateRole("Administrator");
            //Roles.CreateRole("Tester");

            //MembershipCreateStatus status;
            //Membership.CreateUser("scrummaster", "scrummaster", "scrummaster@fuckyou.com", "Who is gay?", "Dan Vincent", true, out status);
            //Membership.CreateUser("projectmanager", "projectmanager", "projectmanager@fuckyou.com", "Who is gay?", "Dan Vincent", true, out status);
            //Membership.CreateUser("developer", "developer", "developer@fuckyou.com", "Who is gay?", "Dan Vincent", true, out status);
            //Membership.CreateUser("administrator", "administrator", "administrator@fuckyou.com", "Who is gay?", "Dan Vincent", true, out status);
            //Membership.CreateUser("tester", "tester", "tester@fuckyou.com", "Who is gay?", "Dan Vincent", true, out status);

            //Roles.AddUsersToRole(new string[] { "scrummaster" }, "Scrum Master");
            //Roles.AddUsersToRole(new string[] { "projectmanager" }, "Project Manager");
            //Roles.AddUsersToRole(new string[] { "developer" }, "Developer");
            //Roles.AddUsersToRole(new string[] { "administrator" }, "Administrator");
            //Roles.AddUsersToRole(new string[] { "tester" }, "Tester");

            if (!Request.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            if (!IsPostBack)
            {
            }
        }
    }
}