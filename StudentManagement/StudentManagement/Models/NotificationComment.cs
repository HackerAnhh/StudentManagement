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
    
    public partial class NotificationComment : BaseViewModel
    {
        private System.Guid _id { get; set; }
        public System.Guid Id { get => _id; set { _id = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idUserComment { get; set; }
        public Nullable<System.Guid> IdUserComment { get => _idUserComment; set { _idUserComment = value; OnPropertyChanged(); } }
        private Nullable<System.Guid> _idNotification { get; set; }
        public Nullable<System.Guid> IdNotification { get => _idNotification; set { _idNotification = value; OnPropertyChanged(); } }
        private string _content { get; set; }
        public string Content { get => _content; set { _content = value; OnPropertyChanged(); } }
        private Nullable<System.DateTime> _time { get; set; }
        public Nullable<System.DateTime> Time { get => _time; set { _time = value; OnPropertyChanged(); } }
    
        public virtual Notification Notification { get; set; }
        public virtual User User { get; set; }
    }
}
