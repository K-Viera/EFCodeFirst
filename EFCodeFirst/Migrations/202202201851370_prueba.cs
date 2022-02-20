namespace EFCodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.BlogPosts", "Prueba", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.BlogPosts", "Prueba");
        }
    }
}
