using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PropEventos.API.Models;

namespace PropEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public IEnumerable<Evento> _evento = new Evento[]{
                new Evento(){
                    EventoId = 1,
                    Tema = "ANGULAR 11 e .NET 5",
                    Local = "Belo Horizonte",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                 new Evento(){
                    EventoId = 2,
                    Tema = "Angular suas novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "minhafotoEvento2.png"
                }
                ,
                 new Evento(){
                    EventoId = 3,
                    Tema = "Angular suas novidades",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "minhafotoEvento3.png"
                },
                 new Evento(){
                    EventoId = 4,
                    Tema = "Angular suas novidades ..",
                    Local = "São Paulo",
                    Lote = "2º Lote",
                    QtdPessoas = 450,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "minhafotoEvento4.png"
                },
                 new Evento(){
                    EventoId = 5,
                    Tema = "Angular suas novidades ..",
                    Local = "São Paulo",
                    Lote = "5º Lote",
                    QtdPessoas = 450,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "minhafotoEvento5.png"
                }
        };

         public EventoController()
        {              
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetbyId(int id)
        {    
            return _evento.Where(evento => evento.EventoId == id);
        }

        [HttpGet]
        public IEnumerable<Evento> Get()
        {    
            return _evento;
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
