using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contratos
{
    internal interface IVista_S_Encuestas_Contestadas
    {
        List<Vista_S_Encuestas_Contestadas> GetContestadas();
        List<Vista_S_Encuestas_Contestadas> ConsultarV(int id);
        List<Vista_S_Encuestas_Contestadas>ConsultarVF(int id,DateTime fecha_In,DateTime fecha_Fin);
        Vista_S_Encuestas_Contestadas Consultar(int id);
        void Agregar(Vista_S_Encuestas_Contestadas _VSECont);
        void Actualizar(Vista_S_Encuestas_Contestadas _VSECont);
        void Eliminar(int id);
    }
}
