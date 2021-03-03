using API.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace API.Controllers
{
    public class PersonaController : Controller
    {
        // GET: Persona
        public ActionResult Index()
        {
            return View();
        }

        List<Persona> personas = new List<Persona>();

        //Como no tenemos BBDD, declaramos en el constructor las personas que estarían en nuestra BBDD

        public PersonaController()
        {   
            // https://es.stackoverflow.com/questions/112848/instanciar-objetos-de-clase-persona-en-una-lista

            List<Persona> personas = new List<Persona>
            {
                new Persona { Id = 1, Nombre = "Osiel", Paterno = "Morales", Materno = "Rosales" },
                new Persona { Id = 2, Nombre = "Nicolás", Paterno = "Morales", Materno = "Rosales" },
                new Persona { Id = 3, Nombre = "Nombre3", Paterno = "Paterno3", Materno = "Materno3" }
             };
         }

        // GET api/<controller>
        //[HttpGet]
        //[Route("Persona/Obtener")]
        public List<Persona> Obtener()
        {
            return this.personas;
        }

        //[Route("Persona/GetPersonas")]
        //public List<Persona> GetPersonas()
        //{
        //    return this.personas;
        //}
    }
}