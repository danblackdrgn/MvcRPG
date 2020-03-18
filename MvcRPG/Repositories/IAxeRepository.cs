using MvcRPG.Models;
using MvcRPG.ModelsDTO;
using System.Collections.Generic;


namespace MvcRPG.Repositories
{
    interface IAxeRepository
    {
        bool AddAxe (AxeDTO AxeItem);
        bool UpdateAxe (int AxeId);
        bool DeleteAxe(int AxeId);
        Axe GetAxeByName (string AxeName);
        ICollection<Axe> GetAllAxesByEnchantment(int EnchantmentId);
        ICollection<Axe> GetAllAxes();
    }
}
