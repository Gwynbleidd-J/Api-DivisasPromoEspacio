using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct Vista_S_Encuestas_Contestadas
    {
        public int Id_Encuesta { get; set; }
        public string Nombre_Encuesta { get; set; }
        public DateTime Fecha_Inicial { get; set; }
        public DateTime Fecha_Final { get; set; }
        public DateTime Fecha_Actualizacion { get; set; }
        public int Id_Encuesta_Contestada { get; set; }
        public string Folio_Encuesta { get; set; }
        public DateTime Fecha_Hora_Inicio { get; set; }
        public DateTime Fecha_Hora_Fin { get; set; }
        public string Id_Usuario { get; set; }
        public string Estatus_Encuestas { get; set; }
        public int Activa { get; set; }
        public int Completa { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Version_App { get; set; }
        public string Nombre_Usuario { get; set; }

        public Vista_S_Encuestas_Contestadas(int id_Encuesta,string nombre_Encuesta,DateTime fecha_Inicial,DateTime fecha_Final,DateTime fecha_Actualizacion,
            int id_EncuestaContestada,string folio_Encuesta,DateTime fecha_Hora_Inicio,DateTime fecha_Hora_Fin,string id_usuario,string estatus_Encuestas,
            int activa,int completa,DateTime fecha_Registro,string version_App, string nombre_Usuario)
        {
            Id_Encuesta= id_Encuesta;
            Nombre_Encuesta= nombre_Encuesta;
            Fecha_Inicial= fecha_Inicial;
            Fecha_Final= fecha_Final;
            Fecha_Actualizacion= fecha_Actualizacion;
            Id_Encuesta_Contestada= id_EncuestaContestada;
            Folio_Encuesta= folio_Encuesta;
            Fecha_Hora_Inicio=fecha_Hora_Inicio;
            Fecha_Hora_Fin= fecha_Hora_Fin;
            Id_Usuario = id_usuario;
            Estatus_Encuestas= estatus_Encuestas;
            Activa=activa;
            Completa= completa;
            Fecha_Registro= fecha_Registro;
            Version_App= version_App;
            Nombre_Usuario= nombre_Usuario;
        }
    }
}
