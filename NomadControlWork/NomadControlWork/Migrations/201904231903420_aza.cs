namespace NomadControlWork.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class aza : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Users", "Adress", c => c.String());
            DropColumn("dbo.Users", "NumberCard");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "NumberCard", c => c.String());
            DropColumn("dbo.Users", "Adress");
        }
    }
}
