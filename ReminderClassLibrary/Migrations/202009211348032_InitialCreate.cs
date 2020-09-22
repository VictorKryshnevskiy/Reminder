namespace ReminderClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.CyclicalNotifications",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Start = c.DateTime(nullable: false),
                        End = c.DateTime(nullable: false),
                        CountDate = c.DateTime(nullable: false),
                        PeriodAmount = c.Int(nullable: false),
                        Period = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reminds", t => t.Id)
                .Index(t => t.Id);
            
            CreateTable(
                "dbo.Reminds",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        Name = c.String(),
                        Description = c.String(),
                        EndDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Notifications",
                c => new
                    {
                        Id = c.Guid(nullable: false, identity: true),
                        RemindId = c.Guid(nullable: false),
                        PeriodAmount = c.Int(nullable: false),
                        Period = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reminds", t => t.RemindId, cascadeDelete: true)
                .Index(t => t.RemindId);
            
            CreateTable(
                "dbo.RemindTasks",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Text = c.String(nullable: false),
                        Status = c.Int(nullable: false),
                        Remind_Id = c.Guid(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Reminds", t => t.Remind_Id)
                .Index(t => t.Remind_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CyclicalNotifications", "Id", "dbo.Reminds");
            DropForeignKey("dbo.RemindTasks", "Remind_Id", "dbo.Reminds");
            DropForeignKey("dbo.Notifications", "RemindId", "dbo.Reminds");
            DropIndex("dbo.RemindTasks", new[] { "Remind_Id" });
            DropIndex("dbo.Notifications", new[] { "RemindId" });
            DropIndex("dbo.CyclicalNotifications", new[] { "Id" });
            DropTable("dbo.RemindTasks");
            DropTable("dbo.Notifications");
            DropTable("dbo.Reminds");
            DropTable("dbo.CyclicalNotifications");
        }
    }
}
