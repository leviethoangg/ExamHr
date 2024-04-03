using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ExamHr.Models;

namespace ExamHr.Data
{
    public class ExamHrContext : DbContext
    {
        public ExamHrContext (DbContextOptions<ExamHrContext> options)
            : base(options)
        {
        }

        public DbSet<ExamHr.Models.Employee> Employee { get; set; } = default!;
    }
}
