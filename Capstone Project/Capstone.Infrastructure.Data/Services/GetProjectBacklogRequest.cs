﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services
{
    public class GetProjectBacklogRequest : ServiceRequest
    {
        public int ProjectID { get; set; }
    }
}
