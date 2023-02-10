using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contratos
{
    internal interface ILst_Supervision_Encuestas
    {
        List<Lst_Supervision_Encuestas> Consultar();
        Lst_Supervision_Encuestas Consultar(int id);
        void Agregar(Lst_Supervision_Encuestas _LEncuestas);
        void Actualizar(Lst_Supervision_Encuestas _LEncuestas);
        void Eliminar(int id);
    }
}
