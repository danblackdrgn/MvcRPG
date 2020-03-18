using MvcRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcRPG.Repositories
{
    interface IEnchantmentRepository
    {
        ICollection<Enchantment> GetAllEnchantmentByElement(string Element);
        ICollection<Enchantment> GetAllEnchantmentByLevel(int Level);
        Enchantment GetEnchantmentById(int Id);
    }
}
