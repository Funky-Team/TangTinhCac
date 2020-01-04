namespace TangTinhCac.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TKC_v6 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Idol", "IdolBirthday", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Idol", "IdolBirthday", c => c.DateTime(nullable: false));
        }
    }
}
