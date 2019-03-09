namespace HomeCareMedical_Test.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddcontentToPersonal : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Personal (FirstName, MiddleName, SurName, DateOfBirth) VALUES('Monika', 'Hiren', 'Patel', '1992-02-19')");
            Sql("INSERT INTO Personal (FirstName, MiddleName, SurName, DateOfBirth) VALUES('Hiren', 'Rameshbhai', 'Patel', '1990-02-10')");

        }

        public override void Down()
        {
        }
    }
}
