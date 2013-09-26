using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Capstone.Application.Web.Base {
    public class BasePage : System.Web.UI.Page {


        protected BaseMasterPage MasterBase {
            get {
                return this.Master as BaseMasterPage;
            }
        }
    }
}