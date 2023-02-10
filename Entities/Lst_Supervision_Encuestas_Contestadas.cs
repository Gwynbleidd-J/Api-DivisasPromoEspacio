using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct Lst_Supervision_Encuestas_Contestadas
    {
        public int Id_Encuesta_Contestada { get; set; }
        public int Id_Encuesta { get; set; }
        public string Folio_Encuesta { get; set; }
        public DateTime Fecha_Hora_Inicio { get; set; }
        public DateTime Fecha_Hora_Fin { get; set; }
        public string Id_Usuario { get; set; }
        public string Estatus_Encuestas { get; set; }
        public int Completa { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Version_App { get; set; }
        public int Activa { get; set; }

        public Lst_Supervision_Encuestas_Contestadas(int id_Encuesta_Contestada, int id_Encuesta,string folio_Encuesta,DateTime fecha_Hora_Inicio,
            DateTime fecha_Hora_Fin,string id_Usuario,string estatus_Encuesta, int completa,DateTime fecha_Registro,string version_App,int activa)
        {
            Id_Encuesta_Contestada=id_Encuesta_Contestada;
            Id_Encuesta=id_Encuesta;
            Folio_Encuesta=folio_Encuesta;
            Fecha_Hora_Inicio=fecha_Hora_Inicio;
            Fecha_Hora_Fin=fecha_Hora_Fin;
            Id_Usuario=id_Usuario;
            Estatus_Encuestas=estatus_Encuesta;
            Completa = completa;
            Fecha_Registro=fecha_Registro;
            Version_App=version_App;
            Activa=activa;
        }
    }
}
