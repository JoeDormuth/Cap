﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class UpdateFeaturesBugsRequest : ServiceRequest
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Comments { get; set; }
        public Guid DeveloperID { get; set; }
    }
}
