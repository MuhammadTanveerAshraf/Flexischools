﻿namespace Flexischools.Data.Models.Request
{
    public class AddStudentRequest
    {
        public required string Name { get; set; }
        public Guid SubjectId { get; set; }
        public Guid LectureId { get; set; }
    }
}
