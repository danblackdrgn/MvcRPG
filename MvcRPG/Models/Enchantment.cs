using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRPG.Models
{
    [Table("Enchantment")]
    public class Enchantment
    {
        public int EnchantmentId { get; set; }

        [StringLength(50)]
        public string Element { get; set; }
        public int Level { get; set; }

    }
}
/*
 Enchantment
EnchantmentId (int)
Element (string)
Level (int)
*/
