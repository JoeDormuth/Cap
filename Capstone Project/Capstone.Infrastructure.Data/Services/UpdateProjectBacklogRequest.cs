using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class UpdateProjectBacklogRequest : ServiceRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime FinishDate { get; set; }
        public string Status { get; set; }
        public DateTime StartDate { get; set; }
    }
}
