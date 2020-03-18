namespace MvcRPG.Migrations
{
    using MvcRPG.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<WeaponDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(WeaponDb context)
        {
            //IList<Axe> defaultAxes = new List<Axe>();
            //IList<Sword> defaultSwords = new List<Sword>();
            //IList<Bow> defaultBows = new List<Bow>();
            //IList<Enchantment> defaultEnchanments = new List<Enchantment>();

            //defaultEnchanments.Add(new Enchantment { Element = "Thunder", Level = 4 });
            //defaultEnchanments.Add(new Enchantment { Element = "Fire", Level = 5 });
            //defaultEnchanments.Add(new Enchantment { Element = "Void", Level = 7 });
            //defaultEnchanments.Add(new Enchantment { Element = "Poison", Level = 2 });
            //defaultEnchanments.Add(new Enchantment { Element = "Energy", Level = 3 });

            //defaultAxes.Add(new Axe { Name = "Stonecutter Axe", Attack = 50, Handler = 1, EnchantmentId = 3 });
            //defaultAxes.Add(new Axe { Name = "Snake Axe", Attack = 29, Handler = 1, EnchantmentId = 4 });
            //defaultAxes.Add(new Axe { Name = "Great Axe", Attack = 70, Handler = 2, EnchantmentId = 1 });

            //defaultSwords.Add(new Sword { Name = "Pharaoh Sword", Attack = 41, Shield = 23, EnchantmentId = 3 });
            //defaultSwords.Add(new Sword { Name = "Magic Sword", Attack = 48, Shield = 35, EnchantmentId = 1 });
            //defaultSwords.Add(new Sword { Name = "Magic Longsword", Attack = 88, Shield = 20, EnchantmentId = 2 });

            //defaultBows.Add(new Bow { Name = "Flaming Bow", Attack = 30, Range = 8, Ammo = 50, EnchantmentId = 2 });
            //defaultBows.Add(new Bow { Name = "Shakirian Bow", Attack = 25, Range = 9, Ammo = 40, EnchantmentId = 5 });
            //defaultBows.Add(new Bow { Name = "Poisoned Bow", Attack = 32, Range = 10, Ammo = 45, EnchantmentId = 4 });

            //context.Enchantments.AddRange(defaultEnchanments);
            //context.Axes.AddRange(defaultAxes);
            //context.Swords.AddRange(defaultSwords);
            //context.Bows.AddRange(defaultBows);

            base.Seed(context);
        }
    }
}
