namespace ReminderClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.RemindTasks", "Remind_Id", "dbo.Reminds");
            DropIndex("dbo.RemindTasks", new[] { "Remind_Id" });
            RenameColumn(table: "dbo.RemindTasks", name: "Remind_Id", newName: "RemindId");
            DropPrimaryKey("dbo.RemindTasks");
            AlterColumn("dbo.RemindTasks", "Id", c => c.Guid(nullable: false, identity: true));
            AlterColumn("dbo.RemindTasks", "Text", c => c.String());
            AlterColumn("dbo.RemindTasks", "RemindId", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.RemindTasks", "Id");
            CreateIndex("dbo.RemindTasks", "RemindId");
            AddForeignKey("dbo.RemindTasks", "RemindId", "dbo.Reminds", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RemindTasks", "RemindId", "dbo.Reminds");
            DropIndex("dbo.RemindTasks", new[] { "RemindId" });
            DropPrimaryKey("dbo.RemindTasks");
            AlterColumn("dbo.RemindTasks", "RemindId", c => c.Guid());
            AlterColumn("dbo.RemindTasks", "Text", c => c.String(nullable: false));
            AlterColumn("dbo.RemindTasks", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.RemindTasks", "Id");
            RenameColumn(table: "dbo.RemindTasks", name: "RemindId", newName: "Remind_Id");
            CreateIndex("dbo.RemindTasks", "Remind_Id");
            AddForeignKey("dbo.RemindTasks", "Remind_Id", "dbo.Reminds", "Id");
        }
    }
}
