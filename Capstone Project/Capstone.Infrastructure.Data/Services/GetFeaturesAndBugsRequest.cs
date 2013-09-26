using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class GetFeaturesAndBugsRequest : ServiceRequest
    {
        public int SprintID { get; set; }
    }
}
