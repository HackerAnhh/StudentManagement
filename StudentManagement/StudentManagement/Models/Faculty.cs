//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace StudentManagement.Models
{
    using StudentManagement.ViewModels;
    using System;
    using System.Collections.Generic;
    
    public partial class Faculty : BaseViewModel
    {
        public Faculty()
        {
            this.Classes = new HashSet<Class>();
            this.Faculty_TrainingForm = new HashSet<Faculty_TrainingForm>();
            this.Students = new HashSet<Student>();
            this.Teachers = new HashSet<Teacher>();
        }
    
        private System.Guid _id { get; set; }
        public System.Guid Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        private string _displayName { get; set; }
        public string DisplayName { get => _displayName; set { _displayName = value; OnPropertyChanged(); } }
        private Nullable<bool> _isDeleted { get; set; }
        public Nullable<bool> IsDeleted { get => _isDeleted; set { _isDeleted = value; OnPropertyChanged(); } }
        private Nullable<System.DateTime> _foundationDay { get; set; }
        public Nullable<System.DateTime> FoundationDay { get => _foundationDay; set { _foundationDay = value; OnPropertyChanged(); } }
    
        public virtual ICollection<Class> Classes { get; set; }
        public virtual ICollection<Faculty_TrainingForm> Faculty_TrainingForm { get; set; }
        public virtual ICollection<Student> Students { get; set; }
        public virtual ICollection<Teacher> Teachers { get; set; }
    }
}