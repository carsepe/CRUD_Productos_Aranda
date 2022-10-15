using ArandaLogicaNegocio.Modelos;
using ArandaLogicaNegocio.Repositorios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArandaLogicaNegocio.Servicios.Implementaciones
{
    public class ProductosService:GenericService<Productos>
    {
        public ProductosService(IProductosRepository productosRepository): base(productosRepository)
        {
                
        }
    }
}
