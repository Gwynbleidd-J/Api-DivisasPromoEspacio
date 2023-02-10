using Domain.Negocio;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class Encuesta_Datos_DivisasController : ApiController
    {
        NEncuesta_Datos_Divisas _NeDD=new NEncuesta_Datos_Divisas();
        List<Encuesta_Datos_Divisas> _Ledd = new List<Encuesta_Datos_Divisas>();
        public List<Encuesta_Datos_Divisas> Get([FromBody]string Fecha)
        {
            _Ledd=_NeDD.Consultar(Fecha);
            return _Ledd;
        }
    }
}
