using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Capstone.Infrastructure.Data.Services {
    public class ServiceResponse<TEntity> {
        /// <summary>
        /// True if the requested result is being returned.
        /// </summary>
        public bool IsSuccess { get; set; }

        /// <summary>
        /// Details about the service response
        /// </summary>
        public string ServiceMessage { get; set; }

        /// <summary>
        /// Response Time
        /// </summary>
        public DateTime Time { get; set; }

        /// <summary>
        /// Return value
        /// </summary>
        public TEntity Result { get; set; }
    }
}
