﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentManagementCoreMVC.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string course_Name { get; set; }

        public DateTime start_date { get; set; }

        public DateTime end_date { get; set; }

        public string course_duration { get; set; }
    }
}
