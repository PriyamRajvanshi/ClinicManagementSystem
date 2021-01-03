namespace ClinicManagementSystemDAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ResetPasswds",
                c => new
                    {
                        UserId = c.Int(nullable: false),
                        Id = c.String(nullable: false, maxLength: 100, unicode: false),
                        ResetRequestDateTime = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            DropColumn("dbo.DoctorAvailabilities", "IsAvailable");
        }
        
        public override void Down()
        {
            AddColumn("dbo.DoctorAvailabilities", "IsAvailable", c => c.Boolean(nullable: false));
            DropForeignKey("dbo.ResetPasswds", "UserId", "dbo.Users");
            DropIndex("dbo.ResetPasswds", new[] { "UserId" });
            DropTable("dbo.ResetPasswds");
        }
    }
}
