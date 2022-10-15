using ArandaLogicaNegocio.Modelos;
using ArandaLogicaNegocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Servicios.Implementaciones
{
   public class CategoriasService : GenericService<Categorias>
    {
        public CategoriasService(ICategoriasRepository categoriasRepository) : base(categoriasRepository)
        {

        }
    }
}
