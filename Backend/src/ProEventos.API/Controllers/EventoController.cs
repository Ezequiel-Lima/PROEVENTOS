using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController(ILogger<EventoController> logger)
        {
           
        }

        [HttpGet]
        public Evento GetEvento()
        {
            return new Evento()
            {
                    EventoId = 1,
                    Tema = "Encontro Turma .NET",
                    Local = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString()
            };     
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
