using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DataAccess.Contratos
{
    internal interface ILst_Usuarios
    {
        List<Lst_Usuarios> Consultar();
        Lst_Usuarios Consultar(int id);
        void Agregar(Lst_Usuarios usuarios);
        void Actualizar(Lst_Usuarios usuarios);
        void Eliminar(int id);
    }
}
