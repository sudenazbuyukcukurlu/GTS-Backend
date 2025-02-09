﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskComment // Talep yönetimi,talep yorumlarını tutar.
    {
        public int Id { get; set; }
        public int TaskId { get; set; }
        public int UserId { get; set; }
        public int QuickAnswerId { get; set; }
        public string? Message { get; set; }
        public int HasAttachment { get; set; }
        public bool AgencyCanView { get; set; }
        public bool ShowOnlyToDepartment { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime UpdateDate { get; set; }
    }
}
