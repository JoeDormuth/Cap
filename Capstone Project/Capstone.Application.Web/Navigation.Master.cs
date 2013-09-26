using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Web.Security;

namespace Capstone.Application.Web
{
    public partial class Navigation : Capstone.Application.Web.Base.BaseMasterPage
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            string path;
            string sRet = String.Empty;

            #region links
            if (!IsPostBack)
            {
               path = HttpContext.Current.Request.Url.AbsolutePath;
               FileInfo oInfo = new System.IO.FileInfo(path);
               sRet = oInfo.Name;
            }

           if (sRet == "Home.aspx")
           {
               Home.Enabled = false;
           }
           else if (sRet == "Project.aspx")
            {
                Projects.Enabled = false;
            }
           else if (sRet == "BugReport.aspx")
           {
               Bugs.Enabled = false;
           }
           else if (sRet == "Feature.aspx")
           {
               Features.Enabled = false;
           }
           else if (sRet == "Admin.aspx")
           {
               Admin.Enabled = false;
           }
           else if (sRet == "Reports.aspx")
           {
               Reports.Enabled = false;
           }

          // User.IsInRole("Administrator");
        }
            #endregion

        protected void SignIn_Click(object sender, EventArgs e)
        {
            FormsAuthentication.SignOut();
            FormsAuthentication.RedirectToLoginPage();
        }
    }
}