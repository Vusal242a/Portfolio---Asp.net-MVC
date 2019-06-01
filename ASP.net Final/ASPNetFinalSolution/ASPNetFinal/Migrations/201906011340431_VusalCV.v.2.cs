namespace ASPNetFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class VusalCVv2 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ErrorHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AreaName = c.String(),
                        ControllerName = c.String(),
                        ActionName = c.String(),
                        ErrorCode = c.Int(),
                        ErrorMessage = c.String(),
                        CreatedDate = c.DateTime(),
                        DeletedDate = c.DateTime(),
                        UpdateDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ErrorHistories");
        }
    }
}
