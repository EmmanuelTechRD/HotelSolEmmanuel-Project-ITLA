using HotelSolEmmanuel.Categoria.Application.DTOs;
using HotelSolEmmanuel.Categoria.Application.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace HotelSolEmmanuel.Categoria.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriaController : ControllerBase
    {
        private readonly ICategoriaService categoriaService;

        public CategoriaController(ICategoriaService categoriaService)
        {
            this.categoriaService = categoriaService;
        }

        // GET: api/<CategoriaController>
        [HttpGet("GetCategorias")]
        public IActionResult Get()
        {
            var result = this.categoriaService.GetCategorias();
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // GET api/<CategoriaController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = this.categoriaService.GetCategorias(id);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // POST api/<CategoriaController>
        [HttpPost("SaveCategoria")]
        public IActionResult Post([FromBody] CategoriaSaveModel categoriaSaveModel)
        {
            var result = this.categoriaService.SaveCategorias(categoriaSaveModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // PUT api/<CategoriaController>/5
        [HttpPut("UpdateCategoria")]
        public IActionResult Put(CategoriaUpdateModel categoriaUpdateModel)
        {
            var result = this.categoriaService.UpdateCategorias(categoriaUpdateModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }

        // DELETE api/<CategoriaController>/5
        [HttpDelete("DeleteCategoria")]
        public IActionResult Delete(CategoriaDeleteModel categoriaDeleteModel)
        {
            var result = this.categoriaService.DeleteCategorias(categoriaDeleteModel);
            if (!result.Success)
            {
                return BadRequest(result);
            }
            else
            {
                return Ok(result);
            }
        }
    }
}
