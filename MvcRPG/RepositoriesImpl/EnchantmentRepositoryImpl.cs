using MvcRPG.Models;
using MvcRPG.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace MvcRPG.RepositoriesImpl
{
    public class EnchantmentRepositoryImpl : IEnchantmentRepository
    {
        public ICollection<Enchantment> GetAllEnchantmentByElement(string Element)
        {
            using (WeaponDb db = new WeaponDb())
            {
                var EnchantmentList = db.Enchantments.Where(e => e.Element == Element).ToList<Enchantment>();
                return EnchantmentList;
            }
        }
        // tam adre wey , ya me acorde
        public ICollection<Enchantment> GetAllEnchantmentByLevel(int Level)
        {
            using (WeaponDb db = new WeaponDb())
            {
                var EnchantmentList = db.Enchantments.Where(e => e.Level == Level).ToList<Enchantment>();
                return EnchantmentList;
            }
        }

        public Enchantment GetEnchantmentById(int Id)
        {
            using (WeaponDb db = new WeaponDb())
            {
                var enchantmentItem = db.Enchantments.Where(e => e.EnchantmentId == Id).FirstOrDefault();
                return enchantmentItem;
            }
        }
    }
}
