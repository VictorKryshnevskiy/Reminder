namespace ReminderClassLibrary.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCompanyMigration1 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.RemindTasks");
            AlterColumn("dbo.RemindTasks", "Id", c => c.Guid(nullable: false));
            AddPrimaryKey("dbo.RemindTasks", "Id");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.RemindTasks");
            AlterColumn("dbo.RemindTasks", "Id", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.RemindTasks", "Id");
        }
    }
}
