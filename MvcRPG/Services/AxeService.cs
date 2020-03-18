using MvcRPG.Models;
using MvcRPG.ModelsDTO;
using MvcRPG.Repositories;
using MvcRPG.RepositoriesImpl;
using System.Collections.Generic;

namespace MvcRPG.Services
{
    public class AxeService
    {
        IAxeRepository axeRepository;
        IEnchantmentRepository enchantmentRepository;
        public AxeService()
        {
            axeRepository = new AxeRepositoryImpl();
            enchantmentRepository = new EnchantmentRepositoryImpl();
        }

        public void AddNewAxe(AxeDTO axeItem)
        {
            if (axeItem != null)
            {
                axeRepository.AddAxe(axeItem);
            }
        }


        public ICollection<Axe> GetAllAxes()
        {
            return axeRepository.GetAllAxes();
        }
    }
}
