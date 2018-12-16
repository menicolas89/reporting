using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Reporting.Models
{
    public class ReportingContext : DbContext
    {
        public ReportingContext(DbContextOptions<ReportingContext> options)
            : base(options)
        {
        }
        public DbSet<Activity> Activities { get; set; }
    }
}
