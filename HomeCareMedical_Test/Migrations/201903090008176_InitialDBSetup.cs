namespace HomeCareMedical_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialDBSetup : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Personal",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false, maxLength: 100),
                        MiddleName = c.String(nullable: false, maxLength: 100),
                        SurName = c.String(nullable: false, maxLength: 100),
                        DateOfBirth = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Personal");
        }
    }
}
