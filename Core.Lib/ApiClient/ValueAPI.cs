using Core.Lib.Helpers;
using Core.Models.Models;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Lib.ApiClient
{
    class ValueAPI :WebApiClient
    {
        public ValueAPI() : base(Settings.Current.WebAPIUrl, "api") { 
        
        }

        public async Task<(HttpStatusCode StatusCode, List<Persona> Data)> Obtener()
        {
            return await CallGetAsync<List<Persona>>("pais");
        }
        public async Task<(HttpStatusCode StatusCode, String Name)> Login(Credential credential)
        {
            return await CallPostAsync < Credential, string>("Login", credential);
        }
    }
}
