namespace KryckoBlogSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ChangedNamefieldtypefrominttostring : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Posts", "Name", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Posts", "Name", c => c.Int(nullable: false));
        }
    }
}
