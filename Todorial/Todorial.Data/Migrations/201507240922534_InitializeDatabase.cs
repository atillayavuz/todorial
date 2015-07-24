namespace Todorial.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitializeDatabase : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsActive = c.Boolean(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TodoItemLists",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        Name = c.String(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.TodoItems",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TodoItemListId = c.Guid(nullable: false),
                        Content = c.String(),
                        IsCompleted = c.Boolean(nullable: false),
                        IsStarred = c.Boolean(nullable: false),
                        DueDate = c.DateTime(),
                        IsDeleted = c.Boolean(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        UpdateDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.TodoItemLists", t => t.TodoItemListId, cascadeDelete: true)
                .Index(t => t.TodoItemListId);
            
            CreateTable(
                "dbo.TodoItemListTags",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        TodoItemListId = c.Guid(nullable: false),
                        TagId = c.Guid(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tags", t => t.TagId, cascadeDelete: true)
                .ForeignKey("dbo.TodoItemLists", t => t.TodoItemListId, cascadeDelete: true)
                .Index(t => t.TodoItemListId)
                .Index(t => t.TagId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.TodoItemListTags", "TodoItemListId", "dbo.TodoItemLists");
            DropForeignKey("dbo.TodoItemListTags", "TagId", "dbo.Tags");
            DropForeignKey("dbo.TodoItems", "TodoItemListId", "dbo.TodoItemLists");
            DropIndex("dbo.TodoItemListTags", new[] { "TagId" });
            DropIndex("dbo.TodoItemListTags", new[] { "TodoItemListId" });
            DropIndex("dbo.TodoItems", new[] { "TodoItemListId" });
            DropTable("dbo.TodoItemListTags");
            DropTable("dbo.TodoItems");
            DropTable("dbo.TodoItemLists");
            DropTable("dbo.Tags");
        }
    }
}
