namespace MvcRoomBooking.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Adicionado_Requerido_Titulo_sala : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Rooms", "Title", c => c.String(nullable: false, maxLength: 60));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Rooms", "Title", c => c.String());
        }
    }
}
