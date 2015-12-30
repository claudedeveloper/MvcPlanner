namespace MvcPlanner.Migrations
{
    using MvcPlanner.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<MvcPlanner.Models.LogDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(MvcPlanner.Models.LogDBContext context)
        {
            //string a = "Monday";
            context.Logs.AddOrUpdate( i => i.ID,
                new Log
                {
                    Subject = "CPE351",
                    Remark = "Remarkable!",
                    Day = "Monday",
                    Date = DateTime.Parse("2012-06-04"),
                    Assignment = "Finish MCSD course!",
                    Time = TimeSpan.Parse("12:30"),
                    Recitation = 98,
                    Comment = "Commendable!",
                    Quiz = 99,
                    Seatwork = 97,
                    Midterm = 95,
                    Final = 93
                },

                new Log
                {
                    Subject = "ENECONV",
                    Remark = "Orientation",
                    Day = "Tuesday",
                    Date = DateTime.Parse("2012-06-05"),
                    //Assignment = "Finish MCSD course!",
                    Time = TimeSpan.Parse("02:00"),
                    Recitation = 91,
                    //Comment = "Commendable!",
                    Quiz = 92,
                    Seatwork = 90,
                    Midterm = 91,
                    Final = 93
                },

                new Log
                {
                    Subject = "CPE351L",
                    Remark = "Remarkable!",
                    Day = "Monday",
                    Date = DateTime.Parse("2012-06-11"),
                    Assignment = "Finish MCSD course!",
                    Time = TimeSpan.Parse("3:30"),
                    Recitation = 96,
                    Comment = "Commendable!",
                    Quiz = 92,
                    Seatwork = 91,
                    Midterm = 95,
                    Final = 93
                }
                );
        }
    }
}
