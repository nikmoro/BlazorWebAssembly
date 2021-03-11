using Core.Models.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace ApiCore.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PersonaController : ControllerBase
    {
        List<Persona> personas = new List<Persona>();

        // Como no tenemos BBDD, declaramos en el constructor las personas que estarían en nuestra BBDD

        public PersonaController()
        {
            // https://es.stackoverflow.com/questions/112848/instanciar-objetos-de-clase-persona-en-una-lista
            Persona p = new Persona { Id = 1, Nombre = "Osiel", Paterno = "Morales", Materno = "Rosales" };
            this.personas.Add(p);
            p = new Persona { Id = 2, Nombre = "Nicolás", Paterno = "Morales", Materno = "Rosales" };
            this.personas.Add(p);
            p = new Persona { Id = 3, Nombre = "Nombre3", Paterno = "Paterno3", Materno = "Materno3" };
            this.personas.Add(p);
            p = new Persona { Id = 4, Nombre = "Nombre4", Paterno = "Paterno4", Materno = "Materno4" };
            this.personas.Add(p);
        }

        // GET api/<controller>
        [HttpGet]
        public List<Persona> Obtener()
        {
            return this.personas;
        }
    }
}
