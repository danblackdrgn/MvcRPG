namespace MvcRPG.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Axe",
                c => new
                    {
                        AxeId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Attack = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Handler = c.Int(nullable: false),
                        EnchantmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.AxeId)
                .ForeignKey("dbo.Enchantment", t => t.EnchantmentId, cascadeDelete: true)
                .Index(t => t.EnchantmentId);
            
            CreateTable(
                "dbo.Enchantment",
                c => new
                    {
                        EnchantmentId = c.Int(nullable: false, identity: true),
                        Element = c.String(maxLength: 50),
                        Level = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.EnchantmentId);
            
            CreateTable(
                "dbo.Bow",
                c => new
                    {
                        BowId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Attack = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Range = c.Int(nullable: false),
                        Ammo = c.Int(nullable: false),
                        EnchantmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.BowId)
                .ForeignKey("dbo.Enchantment", t => t.EnchantmentId, cascadeDelete: true)
                .Index(t => t.EnchantmentId);
            
            CreateTable(
                "dbo.Sword",
                c => new
                    {
                        SwordId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 25),
                        Attack = c.Decimal(nullable: false, precision: 18, scale: 2),
                        Shield = c.Decimal(nullable: false, precision: 18, scale: 2),
                        EnchantmentId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.SwordId)
                .ForeignKey("dbo.Enchantment", t => t.EnchantmentId, cascadeDelete: true)
                .Index(t => t.EnchantmentId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Sword", "EnchantmentId", "dbo.Enchantment");
            DropForeignKey("dbo.Bow", "EnchantmentId", "dbo.Enchantment");
            DropForeignKey("dbo.Axe", "EnchantmentId", "dbo.Enchantment");
            DropIndex("dbo.Sword", new[] { "EnchantmentId" });
            DropIndex("dbo.Bow", new[] { "EnchantmentId" });
            DropIndex("dbo.Axe", new[] { "EnchantmentId" });
            DropTable("dbo.Sword");
            DropTable("dbo.Bow");
            DropTable("dbo.Enchantment");
            DropTable("dbo.Axe");
        }
    }
}
