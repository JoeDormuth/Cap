//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace Capstone.Infrastructure.Data.EF.Entities
{
    [DataContract(IsReference=true)]
    public partial class aspnet_PersonalizationAllUsers
    {
    	[Required]
        [DataMember]
        public System.Guid PathId { get; set; }
    	[Required]
        [DataMember]
        public byte[] PageSettings { get; set; }
    	[Required]
        [DataMember]
        public System.DateTime LastUpdatedDate { get; set; }
    
        [DataMember]
        public virtual aspnet_Paths aspnet_Paths { get; set; }
    }
    
}
