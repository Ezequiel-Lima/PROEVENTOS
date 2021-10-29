using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        private readonly DataContext _context;
        public EventoController(DataContext context)
        {
           _context = context;
        }

        [HttpGet]
        public IEnumerable<Evento> GetEvento()
        {
            return _context.Eventos;   
        }

        [HttpPost]
        public string Post()
        {
            return "Método Post";
        }

        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"Método Delete Com o id:{id}";
        }
    }
}
