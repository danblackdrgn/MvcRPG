using MvcRPG.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRPG.ModelsDTO
{
    public class AxeDTO
    {
        public int AxeId { get; set; }
        public string Name { get; set; }
        public decimal Attack { get; set; }
        public int Handler { get; set; }
        public int EnchantmentId { get; set; }
        public Enchantment Enchantment { get; set; }
    }
}