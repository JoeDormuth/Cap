using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class CreateReleseBacklogRequest : ServiceRequest
    {
        public int ProjectBacklogID { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
    }
}
