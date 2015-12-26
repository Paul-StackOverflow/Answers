namespace MVCAnswers.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ctTerminalTimeZone : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ctTerminalTimeZones", "HiddenValue", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.ctTerminalTimeZones", "HiddenValue");
        }
    }
}
