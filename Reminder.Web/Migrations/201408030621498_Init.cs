namespace Reminder.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "HangFire.Counter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 100),
                        Value = c.Short(nullable: false),
                        ExpireAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HangFire.Hash",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 100),
                        Field = c.String(nullable: false, maxLength: 100),
                        Value = c.String(),
                        ExpireAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HangFire.JobParameter",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 40),
                        Value = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("HangFire.Job", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            CreateTable(
                "HangFire.Job",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StateId = c.Int(),
                        StateName = c.String(maxLength: 20),
                        InvocationData = c.String(nullable: false),
                        Arguments = c.String(nullable: false),
                        CreatedAt = c.DateTime(nullable: false),
                        ExpireAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HangFire.State",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        Name = c.String(nullable: false, maxLength: 20),
                        Reason = c.String(maxLength: 100),
                        CreatedAt = c.DateTime(nullable: false),
                        Data = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("HangFire.Job", t => t.JobId, cascadeDelete: true)
                .Index(t => t.JobId);
            
            CreateTable(
                "HangFire.JobQueue",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        JobId = c.Int(nullable: false),
                        Queue = c.String(nullable: false, maxLength: 20),
                        FetchedAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HangFire.List",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 100),
                        Value = c.String(),
                        ExpireAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Messages",
                c => new
                    {
                        GUID = c.String(nullable: false, maxLength: 50),
                        UserGUID = c.String(maxLength: 50),
                        DateOFBirth = c.DateTime(),
                        Message = c.String(maxLength: 10, fixedLength: true),
                        Notify = c.Boolean(),
                        Status = c.Boolean(),
                    })
                .PrimaryKey(t => t.GUID)
                .ForeignKey("dbo.Users", t => t.UserGUID)
                .Index(t => t.UserGUID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        GUID = c.String(nullable: false, maxLength: 50),
                        Token = c.String(maxLength: 10, fixedLength: true),
                        FirstName = c.String(maxLength: 10, fixedLength: true),
                        LastName = c.String(maxLength: 10, fixedLength: true),
                    })
                .PrimaryKey(t => t.GUID);
            
            CreateTable(
                "HangFire.Schema",
                c => new
                    {
                        Version = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Version);
            
            CreateTable(
                "HangFire.Server",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 50),
                        Data = c.String(),
                        LastHeartbeat = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "HangFire.Set",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Key = c.String(nullable: false, maxLength: 100),
                        Score = c.Double(nullable: false),
                        Value = c.String(nullable: false, maxLength: 256),
                        ExpireAt = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        RoleId = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.RoleId, t.UserId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.RoleId)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Messages", "UserGUID", "dbo.Users");
            DropForeignKey("HangFire.JobParameter", "JobId", "HangFire.Job");
            DropForeignKey("HangFire.State", "JobId", "HangFire.Job");
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.Messages", new[] { "UserGUID" });
            DropIndex("HangFire.State", new[] { "JobId" });
            DropIndex("HangFire.JobParameter", new[] { "JobId" });
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropTable("dbo.AspNetUserRoles");
            DropTable("HangFire.Set");
            DropTable("HangFire.Server");
            DropTable("HangFire.Schema");
            DropTable("dbo.Users");
            DropTable("dbo.Messages");
            DropTable("HangFire.List");
            DropTable("HangFire.JobQueue");
            DropTable("HangFire.State");
            DropTable("HangFire.Job");
            DropTable("HangFire.JobParameter");
            DropTable("HangFire.Hash");
            DropTable("HangFire.Counter");
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetRoles");
        }
    }
}
