using ArandaLogicaNegocio.Dotos;
using ArandaLogicaNegocio.DTOs;
using ArandaLogicaNegocio.Repositorios.Implementaciones;
using ArandaLogicaNegocio.Servicios.Implementaciones;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace ArandaAPI.Controllers
{
    public class ProductosController : ApiController
    {
        private IMapper mapper;
        
        private readonly ProductosService productosService = new ProductosService(new ProductosRepository(ArandaContext.Create()));

        public ProductosController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var productos = await productosService.GetAll();
            var productosDTO = productos.Select(x => mapper.Map<ProductosDTO>(x));

            return Ok(productosDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var productos = await productosService.GetById(id);

            if(productos == null)
                return NotFound();

            var productosDTO = mapper.Map<ProductosDTO>(productos);

            return Ok(productosDTO);
        }
    }
}
