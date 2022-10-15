using ArandaLogicaNegocio.Dotos;
using ArandaLogicaNegocio.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Repositorios.Implementaciones
{
    public class ProductosRepository:GenericRepository<Productos>
    {
        public ProductosRepository(ArandaContext arandaContext): base(arandaContext)
        {

        }
    }
}
