using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace API.Models
{
    public class Persona
    {
        public int Id { set; get; }
        public string Nombre { set; get; }
        public string Paterno { set; get; }
        public string Materno { set; get; }
    }
}