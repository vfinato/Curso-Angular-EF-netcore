using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventoController : ControllerBase
    {
        public EventoController()
        { 
        }

        private IEnumerable<Evento> _eventos = new Evento[]{
                new Evento() {
                    EventoId = 1,
                    Tema = "Angular 11 e .net 5",
                    Local = "Barra Bonita",
                    Lote = "1º Lote",
                    QtdPessoas = 250,
                    DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto.png"
                },
                new Evento(){
                    EventoId = 2,
                    Tema = "Angular e outros",
                    Local = "Barra Bonita",
                    Lote = "2º Lote",
                    QtdPessoas = 350,
                    DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
                    ImagemURL = "foto1.png"
                }
        };

        [HttpGet]
        public IEnumerable<Evento> Get()
        {

            return _eventos;
            
        }

        [HttpGet("{id}")]
        public IEnumerable<Evento> GetById(int id)
        {

            return _eventos.Where(e => e.EventoId == id);
            
        }

        [HttpPost]
        public string Post()
        {
            return "exemplo de post";
        }

        [HttpPut("{id}")]
        public string Put(int id)
        {
            return $"exemplo de put com id = {id}";
        }

        [HttpDelete("{id}")]
        public string Post(int id)
        {
            return $"exemplo de delete com id = {id}";
        }
    }
}