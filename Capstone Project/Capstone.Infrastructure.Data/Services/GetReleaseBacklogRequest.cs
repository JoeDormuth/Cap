using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class GetReleaseBacklogRequest : ServiceRequest
    {
        public int BacklogID { get; set; }
    }
}
