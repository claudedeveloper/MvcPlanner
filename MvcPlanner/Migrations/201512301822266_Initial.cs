namespace MvcPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Logs",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Subject = c.String(),
                        Remark = c.String(),
                        Day = c.String(nullable: false),
                        Date = c.DateTime(nullable: false),
                        Assignment = c.String(),
                        Time = c.Time(nullable: false, precision: 7),
                        Recitation = c.Int(),
                        Comment = c.String(),
                        Quiz = c.Int(),
                        Seatwork = c.Int(),
                        Midterm = c.Int(),
                        Final = c.Int(),
                    })
                .PrimaryKey(t => t.ID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Logs");
        }
    }
}
