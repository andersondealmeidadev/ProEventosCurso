using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Data;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    // public IEnumerable<Evento> _evento = new Evento[]{
    //       new Evento(){
    //          EventoId = 1,
    //          Tema = "Angular e .net",
    //          Local = "São Paulo",
    //          Lote = "1º lote",
    //          QtdPessoas = 250,
    //          DataEvento = DateTime.Now.AddDays(2).ToString("dd/MM/yyyy"),
    //          ImagemURL = "foto.png"
    //       },
    //       new Evento(){
    //          EventoId = 2,
    //          Tema = "Angular e .net e novidades",
    //          Local = "São Paulo",
    //          Lote = "2º lote",
    //          QtdPessoas = 200,
    //          DataEvento = DateTime.Now.AddDays(3).ToString("dd/MM/yyyy"),
    //          ImagemURL = "foto1.png"
    //       }
    //       };
    private readonly DataContext _context;

    public EventoController(DataContext context)
    {
        _context = context;
    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _context.Eventos;
    }

    [HttpGet("{id}")]
    public Evento GetById(int id)
    {
        return _context.Eventos.FirstOrDefault(evento => evento.EventoId == id);
    }
}
