using GestaoReceitas.Domain.Entities;
using Infrastructure.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GestaoReceitasApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IngredienteController : ControllerBase
    {
        private readonly DataContext _context;

        public IngredienteController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<List<Ingredientes>>> GetIngredientes()
        {
            var ingredientes = await _context.Ingredientes.ToListAsync();

            return Ok(ingredientes);
        }
    }
}
