using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
using DataAccess.Repositorys;

namespace Domain.Negocio
{
    public class NVista_S_Encuestas_Contestadas
    {
        DVista_S_Encuestas_Contestadas _DVEC=new DVista_S_Encuestas_Contestadas();
        Vista_S_Encuestas_Contestadas _VCE=new Vista_S_Encuestas_Contestadas();
        List<Vista_S_Encuestas_Contestadas> _LVCE = new List<Vista_S_Encuestas_Contestadas>();

        public List<Vista_S_Encuestas_Contestadas> GetAll()
        {
            _LVCE = _DVEC.GetContestadas();
            return _LVCE;
        }
        public List<Vista_S_Encuestas_Contestadas>GetAllID(int id)
        {
            _LVCE= _DVEC.ConsultarV(id);
            return _LVCE;
        }
        public List<Vista_S_Encuestas_Contestadas>GetAllIdF(int id, DateTimeDif _Tdif) 
        {
            _LVCE=_DVEC.ConsultarVF(id, _Tdif.F_Inicio, _Tdif.F_Fin);
            return _LVCE;
        }
        public Vista_S_Encuestas_Contestadas GetAll(int id)
        {
            _VCE=_DVEC.Consultar(id);
            return _VCE;
        }
    }
}
