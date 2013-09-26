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
    public partial class ReleaseBacklog
    {
        public ReleaseBacklog()
        {
            this.Sprints = new HashSet<Sprint>();
        }
    
        [DataMember]
        public int ID { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Name { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Type { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreationDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FinishDate { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public Nullable<System.DateTime> StartDate { get; set; }
    	[Required]
        [DataMember]
        public int ProjectBacklogID { get; set; }
    
        [DataMember]
        public virtual ProjectBacklog ProjectBacklog { get; set; }
        public virtual ICollection<Sprint> Sprints { get; set; }
    }
    
}