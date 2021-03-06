﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Proffy.CourseMicroservice.Domain.AggregatesModel.CourseAggregate
{
    public class TeacherCourseSchedule
    {
        public Guid Id { get; set; }
        [Required]
        public Guid TeacherCourseId { get; set; }
        [Required]
        public int WeekDay { get; set; }
        [Required]
        public int From { get; set; }
        [Required]
        public int To { get; set; }
        public TeacherCourse TeacherCourse { get; set; }
    }
}
