using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using StudentManagementCoreMVC.Models;

namespace StudentManagementCoreMVC.Data
{
    public class StudentManagementCoreMVCContext : DbContext
    {
        public StudentManagementCoreMVCContext (DbContextOptions<StudentManagementCoreMVCContext> options)
            : base(options)
        {
        }

        public DbSet<StudentManagementCoreMVC.Models.Course> Course { get; set; }

        public DbSet<StudentManagementCoreMVC.Models.Student> Student { get; set; }
    }
}
