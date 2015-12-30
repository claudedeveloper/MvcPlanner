using System;
using System.Data.Entity;

namespace MvcPlanner.Models
{
    public class Log
    {
        public int ID { get; set; }
        public string Subject { get; set; }
        public string Remark { get; set; }
        public string Day { get; set; }
        public DateTime Date { get; set; }
        public string Assignment { get; set; }
        public TimeSpan Time { get; set; }
        public int? Recitation { get; set; }
        public string Comment { get; set; }
        public int? Quiz { get; set; }
        public int? Seatwork { get; set; }
        public int? Midterm { get; set; }
        public int? Final { get; set; }

    }

    public class LogDBContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
    }
}