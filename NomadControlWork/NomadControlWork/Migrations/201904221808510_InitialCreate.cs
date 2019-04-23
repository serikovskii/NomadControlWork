namespace NomadControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Deliveries",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JournalId = c.Guid(nullable: false),
                        UserId = c.Guid(nullable: false),
                        Status = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Journals",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                        NumberJournal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Prints",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        JournalId = c.Guid(nullable: false),
                        Edition = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        FullName = c.String(),
                        Subscribe = c.Boolean(nullable: false),
                        TimeSubscribe = c.Int(nullable: false),
                        Delivered = c.Boolean(nullable: false),
                        NumberCard = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
            DropTable("dbo.Prints");
            DropTable("dbo.Journals");
            DropTable("dbo.Deliveries");
        }
    }
}
