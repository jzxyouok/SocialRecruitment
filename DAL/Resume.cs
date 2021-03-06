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
    
    public partial class Resume
    {
        public Resume()
        {
            this.DegreeSchool = new HashSet<DegreeSchool>();
            this.FileUploader = new HashSet<FileUploader>();
            this.InternshipExperience = new HashSet<InternshipExperience>();
            this.ITAbility = new HashSet<ITAbility>();
            this.LanguageCompetence = new HashSet<LanguageCompetence>();
            this.ProjectExperience = new HashSet<ProjectExperience>();
        }
    
        public string Id { get; set; }
        public string AccountId { get; set; }
        public string Name { get; set; }
        public string Remark { get; set; }
        public Nullable<int> Sort { get; set; }
        public string State { get; set; }
        public Nullable<System.DateTime> CreateTime { get; set; }
        public string CreatePerson { get; set; }
        public Nullable<System.DateTime> UpdateTime { get; set; }
        public string UpdatePerson { get; set; }
        public byte[] Version { get; set; }
        public int CompletionPercentage { get; set; }
    
        public virtual ICollection<DegreeSchool> DegreeSchool { get; set; }
        public virtual ICollection<FileUploader> FileUploader { get; set; }
        public virtual ICollection<InternshipExperience> InternshipExperience { get; set; }
        public virtual ICollection<ITAbility> ITAbility { get; set; }
        public virtual ICollection<LanguageCompetence> LanguageCompetence { get; set; }
        public virtual ICollection<ProjectExperience> ProjectExperience { get; set; }
    }
}
