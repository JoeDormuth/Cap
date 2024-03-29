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

namespace Capstone.Infrastructure.Data.EF
{
    [DataContract(IsReference=true)]
    public partial class Feature_Bugs
    {
        [DataMember]
        public int ID { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Name { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Type { get; set; }
    	[StringLength(100)]
        [DataMember]
        public string Description { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string Status { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string DeveloperID { get; set; }
    	[StringLength(150)]
        [DataMember]
        public string DeveloperNotes { get; set; }
        [DataMember]
        public Nullable<int> ReferenceID { get; set; }
        [DataMember]
        public Nullable<System.DateTime> CreationDate { get; set; }
        [DataMember]
        public Nullable<System.DateTime> FinishedDate { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string TimeEstimate { get; set; }
    	[StringLength(50)]
        [DataMember]
        public string TimeSpent { get; set; }
    }
    
}
