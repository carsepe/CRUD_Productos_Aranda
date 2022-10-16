using ArandaLogicaNegocio.Dotos;
using ArandaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Repositorios.Implementaciones
{
   public class CategoriasRepository : GenericRepository<Categorias>, ICategoriasRepository
    {
        public CategoriasRepository(ArandaContext arandaContext) : base(arandaContext)
        {

        }

    }
}
