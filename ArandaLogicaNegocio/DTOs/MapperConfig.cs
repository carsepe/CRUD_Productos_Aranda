using ArandaLogicaNegocio.Modelos;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.DTOs
{
    public class MapperConfig
    {
        public static MapperConfiguration MapperConfiguration()
        {
            return new MapperConfiguration(cfg => {
                cfg.CreateMap<Productos, ProductosDTO>();
                cfg.CreateMap<ProductosDTO, Productos>();
                
                cfg.CreateMap<Categorias, CategoriasDTO>();
                cfg.CreateMap<CategoriasDTO, Categorias>();
            });
        }
    }
}
