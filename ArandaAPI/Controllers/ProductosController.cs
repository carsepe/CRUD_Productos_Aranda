using ArandaLogicaNegocio.Dotos;
using ArandaLogicaNegocio.DTOs;
using ArandaLogicaNegocio.Modelos;
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
    [RoutePrefix("api/Productos")]
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

            if (productos == null)
                return NotFound();

            var productosDTO = mapper.Map<ProductosDTO>(productos);

            return Ok(productosDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> PostProducto(ProductosDTO productosDTO)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var producto = mapper.Map<Productos>(productosDTO);
                producto = await productosService.Insert(producto);
                return Ok(producto);
            }
            catch (Exception ex) { return InternalServerError(ex); }

        }

        [HttpPut]
        public async Task<IHttpActionResult> PutProducto(ProductosDTO productosDTO, int id)
        {
            if (!ModelState.IsValid) 
                return BadRequest(ModelState);

            if (productosDTO.pro_id != id)
                return BadRequest();

            var valProducto = await productosService.GetById(id);

            if (valProducto == null)
                return NotFound();

            try
            {
                var producto = mapper.Map<Productos>(productosDTO);
                producto = await productosService.Update(producto);
                return Ok(producto);
            }
            catch (Exception ex) { return InternalServerError(ex); }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeletProducto(int id)
        {

            var valProducto = await productosService.GetById(id);

            if (valProducto == null)
                return NotFound();

            try
            {
                await productosService.Delete(id);
                return Ok();
            }
            catch (Exception ex) { return InternalServerError(ex); }
        }

    }
}
