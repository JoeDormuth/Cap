// --------------------------------------------
// <auto-generated>
//	  This code was generated from a template
// </auto-generated>
// --------------------------------------------

using System;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Capstone.Infrastructure.Data.EF.Entities;
using Capstone.Infrastructure.Data.Interface;
using Capstone.Infrastructure.Data.EF;

namespace Capstone.Infrastructure.Data.Repositories {
    public partial class PermissionRepository : BaseRepository<Permission>, IPermissionRepository {
    	
    	public PermissionRepository(IUnitOfWork _uow) : base(_uow) {
    	}
    }
}
