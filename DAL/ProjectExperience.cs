//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace Langben.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class ProjectExperience
    {
        public string Id { get; set; }
        public string ResumeId { get; set; }
        public System.DateTime BeginDate { get; set; }
        public Nullable<System.DateTime> EndDate { get; set; }
        public string IsNow { get; set; }
        public string ProjectName { get; set; }
        public string Job { get; set; }
        public string ProjectDescription { get; set; }
        public Nullable<int> Sort { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdatePerson { get; set; }
        public byte[] Version { get; set; }
    
        public virtual Resume Resume { get; set; }
    }
}
