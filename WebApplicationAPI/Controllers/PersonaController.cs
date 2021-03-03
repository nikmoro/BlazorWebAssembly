using System.Collections.Generic;
using System.Web.Http;
using WebApplicationAPI.Models;

namespace WebApplicationAPI.Controllers
{
    public class PersonaController : ApiController
    {
        List<Persona> personas = new List<Persona>();

        //Como no tenemos BBDD, declaramos en el constructor las personas que estarían en nuestra BBDD

        // https://es.stackoverflow.com/questions/112848/instanciar-objetos-de-clase-persona-en-una-lista
        //readonly List<Persona> personas = new List<Persona> {
        // new Persona { Id = 1, Nombre = "Osiel", Paterno = "Morales", Materno = "Rosales" },
        // new Persona { Id = 2, Nombre = "Nicolás", Paterno = "Morales", Materno = "Rosales" },
        // new Persona { Id = 3, Nombre = "Nombre3", Paterno = "Paterno3", Materno = "Materno3" }
        // };

        public PersonaController()
        {
            Persona p = new Persona { Id = 1, Nombre = "Osiel", Paterno = "Morales", Materno = "Rosales" };
            this.personas.Add(p);
            p = new Persona { Id = 2, Nombre = "Nicolás", Paterno = "Morales", Materno = "Rosales" };
            this.personas.Add(p);
            p = new Persona { Id = 3, Nombre = "Nombre3", Paterno = "Paterno3", Materno = "Materno3" };
            this.personas.Add(p);
        }

        // GET api/<controller>

        public List<Persona> GetPersonas()
        {
            return this.personas;
        }
    }
}
