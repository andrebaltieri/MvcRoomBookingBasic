namespace MvcRoomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Removido_campo_status : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Rooms", "Status");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Rooms", "Status", c => c.Int(nullable: false));
        }
    }
}
