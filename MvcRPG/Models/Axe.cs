using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcRPG.Models
{
    [Table("Axe")]
    public class Axe
    {
        public int AxeId { get; set; }

        [Required]
        [StringLength(25)]
        public string Name { get; set; }
        public decimal Attack { get; set; }
        public int Handler { get; set; }
        public int EnchantmentId { get; set; }

        [ForeignKey("EnchantmentId")]
        public Enchantment Enchantment { get; set; }
    }
}
/*
 * 
 * 
Axe
AxeId (int)
Name (string)
Attack (Decimal)
Handler (int)
EchantmentId (int)

 * 
 * 
 * */
