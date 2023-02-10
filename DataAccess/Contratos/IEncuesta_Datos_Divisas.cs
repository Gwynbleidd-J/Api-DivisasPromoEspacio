using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Entities;

namespace DataAccess.Contratos
{
    internal interface IEncuesta_Datos_Divisas
    {
        List<Encuesta_Datos_Divisas> Consultar(string F_Encuesta);
        Encuesta_Datos_Divisas Conulta(int id);
        void Eliminar(int id);
        void Agregar(Encuesta_Datos_Divisas _Edd);
        void Editar(Encuesta_Datos_Divisas _Edd);
    }
}
