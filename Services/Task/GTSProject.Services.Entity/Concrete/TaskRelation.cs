﻿namespace GTSProject.Services.Entity.Concrete
{
    public class TaskRelation // Talep ilişkilerini içerir.
    {
        public int Id { get; set; }
        public int TaskId1 { get; set; }
        public int UserId { get; set; }
        public int RelationTypeId { get; set; }
        public int TaskId2 { get; set; }
    }
}
