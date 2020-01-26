using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using Laboratorio_0.Modelo;
using Laboratorio_0.Helpers;


namespace Laboratorio_0.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        

        [HttpGet]
        public ActionResult<string> Get()
        {
            return "/Ultimas";
        }

        [HttpPost]
        public void Post([FromBody]object jsonObtenido)
        {
            var jsonString = jsonObtenido.ToString();
            var nueva = JsonConvert.DeserializeObject<Peliculas>(jsonString);

            DATA.Instance.misPelis.Push(nueva); 
        }

        [HttpGet("Ultimas")]
        public ActionResult<string> UltimasPelis()
        {
            int i = 0;
            Peliculas[] Ultimos = new Peliculas[10];

            if (DATA.Instance.misPelis != null)
            { 
                foreach (var item in DATA.Instance.misPelis)
                {
                    if (i <= 9) { Ultimos[i] = item; }
                    i++;
                    
                }
            }
            return JsonConvert.SerializeObject(Ultimos);
        }




    }
}
