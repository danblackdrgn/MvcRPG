using MvcRPG.Models;
using MvcRPG.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcRPG.Services
{
    public static class ConverterDTOToModel
    {

        public static Axe ConvertAxeDTOToAxeModel(AxeDTO axeDTO)
        {
            return new Axe()
            {
                Name = axeDTO.Name,
                Attack = axeDTO.Attack,
                Handler = axeDTO.Handler,
                EnchantmentId = axeDTO.EnchantmentId
            };
        }
    }
}