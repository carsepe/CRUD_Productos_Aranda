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
    public class CategoriasController : ApiController
    {
        private IMapper mapper;

        private readonly CategoriasService categoriasService = new CategoriasService(new CategoriasRepository(ArandaContext.Create()));

        public CategoriasController()
        {
            this.mapper = WebApiApplication.MapperConfiguration.CreateMapper();
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetAll()
        {
            var categoria = await categoriasService.GetAll();
            var categoriasDTO = categoria.Select(x => mapper.Map<CategoriasDTO>(x));

            return Ok(categoriasDTO);
        }

        [HttpGet]
        public async Task<IHttpActionResult> GetById(int id)
        {
            var categoria = await categoriasService.GetById(id);

            if (categoria == null)
                return NotFound();

            var categoriasDTO = mapper.Map<CategoriasDTO>(categoria);

            return Ok(categoriasDTO);
        }

        [HttpPost]
        public async Task<IHttpActionResult> GetById(CategoriasDTO categoriasDTO)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState);

            try
            {
                var categoria = mapper.Map<Categorias>(categoriasDTO);
                categoria = await categoriasService.Insert(categoria);
                return Ok(categoria);
            }
            catch (Exception ex) { return InternalServerError(ex); }

        }

        [HttpPut]
        public async Task<IHttpActionResult> PutCategoria(CategoriasDTO categoriasDTO, int id)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            if (categoriasDTO.cat_id != id)
                return BadRequest();

            var valCategoria = await categoriasService.GetById(id);

            if (valCategoria == null)
                return NotFound();

            try
            {
                var categoria = mapper.Map<Categorias>(categoriasDTO);
                categoria = await categoriasService.Update(categoria);
                return Ok(categoria);
            }
            catch (Exception ex) { return InternalServerError(ex); }
        }

        [HttpDelete]
        public async Task<IHttpActionResult> DeletCategoria(int id)
        {

            var valCategoria = await categoriasService.GetById(id);

            if (valCategoria == null)
                return NotFound();

            try
            {
                await categoriasService.Delete(id);
                return Ok();
            }
            catch (Exception ex) { return InternalServerError(ex); }
        }
    }
}
