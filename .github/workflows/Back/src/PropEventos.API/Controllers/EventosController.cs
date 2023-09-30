using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropEventos.API.Data;
using PropEventos.API.Models;

namespace PropEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventosController : ControllerBase
    {
        
        private readonly DataContext _context;

         public EventosController(DataContext context)
        {              
            this._context = context;
        }

        [HttpGet("{id}")]
        public Evento GetbyId(int id)
        {    
            return _context.Eventos.FirstOrDefault(
                evento => evento.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {    
            return _context.Eventos;
        }

        [HttpPost]
        public String Post()
        {       
            return "Exemplo post";
        }
    
        [HttpPut("{id}")]
        public String Put(int id)
        {       
            return $"Exemplo Put com id = {id}";
        } 

        [HttpDelete("{id}")]
        public String Delete(int id)
        {       
            return $"Exemplo Delete com id = {id}";
        } 

    }
}
