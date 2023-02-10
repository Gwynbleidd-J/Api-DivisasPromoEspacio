using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entities;
using Domain.Negocio;

namespace Presentation.Controllers
{
    public class Supervision_Encuetas_ContestadasController : ApiController
    {
        NVista_S_Encuestas_Contestadas _Nvsec=new NVista_S_Encuestas_Contestadas();
        Vista_S_Encuestas_Contestadas _Vsec = new Vista_S_Encuestas_Contestadas();
        List<Vista_S_Encuestas_Contestadas> _Lvsec = new List<Vista_S_Encuestas_Contestadas>();

        //public List<Vista_S_Encuestas_Contestadas>Get()
        //{
        //    _Lvsec=_Nvsec.GetAll();
        //    return _Lvsec;
        //}
        public List<Vista_S_Encuestas_Contestadas>Get(int id)
        {
            _Lvsec=_Nvsec.GetAllID(id);
            return _Lvsec;
        }
        public List<Vista_S_Encuestas_Contestadas>Post(int id, [FromBody] DateTimeDif _Dif)
        {
            _Lvsec=_Nvsec.GetAllIdF(id, _Dif);
            return _Lvsec;
        }
    }
}
