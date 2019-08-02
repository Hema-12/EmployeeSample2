namespace EmployeeApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Emps",
                c => new
                    {
                        EmployeeId = c.Int(nullable: false, identity: true),
                        FirstName = c.String(nullable: false),
                        LastName = c.String(),
                        Gender = c.String(nullable: false),
                        PhoneNumber = c.String(nullable: false),
                        EmailID = c.String(nullable: false),
                        PostalCode = c.String(nullable: false),
                        Retired = c.Boolean(nullable: false),
                        StateName = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EmployeeId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Emps");
        }
    }
}
