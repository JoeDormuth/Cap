using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Security;
using Capstone.Infrastructure.Data.EF;
using Capstone.Infrastructure.Data.Repositories;
using System.Collections;
using System.Data;
using System.Data.SqlClient;
using Capstone.Application.Web;
using Capstone.Application.Web.Models;


namespace Capstone.Application.Web.Project {

    public partial class Project : System.Web.UI.Page {

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Request.IsAuthenticated)
            {
                FormsAuthentication.RedirectToLoginPage();
            }

            
        }
    }
}