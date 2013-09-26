using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class UpdateProjectRequest : ServiceRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string Client { get; set; }
    }
}