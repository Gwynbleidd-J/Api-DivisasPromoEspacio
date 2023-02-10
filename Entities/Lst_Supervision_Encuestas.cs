using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct Lst_Supervision_Encuestas
    {
        public int Id_Encuesta { get; set; }
        public string Nombre_Encuesta { get; set; }
        public DateTime Fecha_Inicial { get; set; }
        public DateTime Fecha_Final { get; set; }
        public DateTime Fecha_Actualizacion { get; set; }
        public int Activo { get; set; }
        public int Publicada { get; set; }
        public int Version { get; set; }
        public int Solicitadas { get; set; }
        public Lst_Supervision_Encuestas(int id_Encuesta,string nombre_Encuesta,DateTime fecha_Inicial,DateTime fecha_Final,DateTime fecha_Actualizacion,
            int activo,int publicada,int version,int solicitadas)
        {
            Id_Encuesta= id_Encuesta;
            Nombre_Encuesta= nombre_Encuesta;
            Fecha_Inicial= fecha_Inicial;
            Fecha_Final= fecha_Final;
            Fecha_Actualizacion= fecha_Actualizacion;
            Activo= activo;
            Publicada= publicada;
            Version= version;
            Solicitadas= solicitadas;
        }
    }
}
