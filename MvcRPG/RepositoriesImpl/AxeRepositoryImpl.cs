using MvcRPG.Models;
using MvcRPG.ModelsDTO;
using MvcRPG.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using MvcRPG.Services;

namespace MvcRPG.RepositoriesImpl
{
    public class AxeRepositoryImpl : IAxeRepository
    {
        IEnchantmentRepository enchantmentRepository;

        public AxeRepositoryImpl()
        {
            enchantmentRepository = new EnchantmentRepositoryImpl();
        }
        public bool AddAxe(AxeDTO AxeItem)
        {

            if (AxeItem != null)
            {
                Axe newAxe = ConverterDTOToModel.ConvertAxeDTOToAxeModel(AxeItem);
                using (WeaponDb db = new WeaponDb())
                {
                    db.Axes.Add(newAxe);
                    db.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        public bool DeleteAxe(int AxeId)
        {
            throw new NotImplementedException();
        }

        public ICollection<Axe> GetAllAxes()
        {
            using (WeaponDb db = new WeaponDb())
            {
                var axes = db.Axes.Include(a => a.Enchantment);
                return axes.ToList();
            }
        }

        public ICollection<Axe> GetAllAxesByEnchantment(int EnchantmentId)
        {
            throw new NotImplementedException();
        }

        public Axe GetAxeByName(string AxeName)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAxe(int AxeId)
        {
            throw new NotImplementedException();
        }
    }
}
