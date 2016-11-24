namespace KryckoBlogSystem.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedCommenttoeachpost : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PostComments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Content = c.String(),
                        CommentAuthor_Id = c.String(maxLength: 128),
                        CommentedPost_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.CommentAuthor_Id)
                .ForeignKey("dbo.Posts", t => t.CommentedPost_Id)
                .Index(t => t.CommentAuthor_Id)
                .Index(t => t.CommentedPost_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.PostComments", "CommentedPost_Id", "dbo.Posts");
            DropForeignKey("dbo.PostComments", "CommentAuthor_Id", "dbo.AspNetUsers");
            DropIndex("dbo.PostComments", new[] { "CommentedPost_Id" });
            DropIndex("dbo.PostComments", new[] { "CommentAuthor_Id" });
            DropTable("dbo.PostComments");
        }
    }
}
