using DataAccess.Repositorys;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Negocio
{
    public class NEncuesta_Datos_Divisas
    {
        public Encuesta_Datos_Divisas _EDD=new Encuesta_Datos_Divisas();
        public List<Encuesta_Datos_Divisas> _Ledd = new List<Encuesta_Datos_Divisas>();
        public DEncuesta_Datos_Divisas _Nedd = new DEncuesta_Datos_Divisas();

        public List<Encuesta_Datos_Divisas>Consultar(string fecha)
        {
            _Ledd=_Nedd.Consultar(fecha);
            return _Ledd;
        }
    }
}
