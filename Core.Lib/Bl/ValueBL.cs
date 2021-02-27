using Core.Lib.ApiClient;
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Lib.Bl
{
    class ValueBL
    {
        private ValueAPI Api = new ValueAPI();

        public async Task<List<Persona>> ObtenerPersonas()
        {
            List<Persona> Personas = new List<Persona>();
            var response = await Api.Obtener();
            if(response.StatusCode == HttpStatusCode.OK)
            {
                Personas = response.Data;
            }
            return Personas;
        }
    }
}
