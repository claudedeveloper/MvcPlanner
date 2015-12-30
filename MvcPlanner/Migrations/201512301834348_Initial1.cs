namespace MvcPlanner.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Logs", "Day", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Logs", "Day", c => c.Int(nullable: false));
        }
    }
}
