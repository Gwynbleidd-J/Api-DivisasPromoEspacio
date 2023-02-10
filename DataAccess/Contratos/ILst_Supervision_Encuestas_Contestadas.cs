using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contratos
{
    internal interface ILst_Supervision_Encuestas_Contestadas
    {
        List<Lst_Supervision_Encuestas_Contestadas> Consultar();
        Lst_Supervision_Encuestas_Contestadas Consultar(int id);
        void Agregar(Lst_Supervision_Encuestas_Contestadas _LSEncuestaC);
        void Actualizar(Lst_Supervision_Encuestas_Contestadas _LSEncuestaC);
        void Eliminar(int id);
    }
}
