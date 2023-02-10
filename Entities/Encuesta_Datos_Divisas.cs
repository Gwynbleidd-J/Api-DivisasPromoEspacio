using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct Encuesta_Datos_Divisas
    {
        public int Id_Encuesta_Contestada { get; set; }
        public int Id_Encuesta { get; set; }
        public string Folio_Encuesta { get; set; }
        public DateTime Fecha_Hora_Inicio { get; set; }
        public DateTime Fecha_Hora_Fin { get; set; }
        public string Id_Usuario { get; set; }
        public string Estatus_Encuesta { get; set; }
        public int Completa { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public string Version_App { get; set; }
        public int Activa { get; set; }
        public int Duracion_Seg { get; set; }
        public string Sucursal_Banco_Azteca { get; set; }
        public string Incidencia { get; set; }
        public string Tipo_Incidencia { get; set; }
        public string Foto_incidencia { get; set; }
        public string Negocio_Competencia { get; set; }
        public string Geolocalizacion { get; set; }
        public int Divisas_Negocio_Dolar { get; set; }
        public int Divisas_Negocio_Euro { get; set; }
        public int Divisas_Negocio_Canadiense { get; set; }
        public string Dolar_Compra { get; set; }
        public string Dolar_Venta { get; set; }
        public string Canadiense_Compra { get; set; }
        public string Canadiense_Venta { get; set; }
        public string Euro_Compra { get; set; }
        public string Euro_Venta { get; set; }
        public string Imagen_Dolar { get; set; }
        public string Imagen_Canadiense { get; set; }
        public string Imagen_Euro { get; set; }
        public Encuesta_Datos_Divisas(int id_Encuesta_Contestada, int id_Encuesta, string folio_Encuesta, DateTime fecha_Hora_Inicio, DateTime fecha_Hora_Fin,
            string id_Usuario, string estatus_Encuesta, int completa, DateTime fecha_Registro, string version_App, int activa, int duracion_Seg, string sucursal_Banco_Azteca,
            string incidencia, string tipo_Incidencia, string foto_Incidncia, string negocio_Competencia, string geolocalizacion, int divisas_Negocio_Dolar, int divisas_Negocio_Euro,
            int divisas_Negocio_Canadiense, string dolar_Compra, string dola_Venta, string canadiense_Compra, string canadiense_Venta, string euro_Compra, string euro_Venta,
            string imagen_Dolar, string imagen_Canadiense, string imagen_Euro)
        {
            Id_Encuesta_Contestada = id_Encuesta_Contestada;
            Id_Encuesta = id_Encuesta;
            Folio_Encuesta = folio_Encuesta;
            Fecha_Hora_Inicio = fecha_Hora_Inicio;
            Fecha_Hora_Fin = fecha_Hora_Fin;
            Id_Usuario = id_Usuario;
            Estatus_Encuesta = estatus_Encuesta;
            Completa = completa;
            Fecha_Registro = fecha_Registro;
            Version_App = version_App;
            Activa = activa;
            Duracion_Seg = duracion_Seg;
            Sucursal_Banco_Azteca = sucursal_Banco_Azteca;
            Incidencia = incidencia;
            Tipo_Incidencia = tipo_Incidencia;
            Foto_incidencia = foto_Incidncia;
            Negocio_Competencia = negocio_Competencia;
            Geolocalizacion = geolocalizacion;
            Divisas_Negocio_Dolar = divisas_Negocio_Dolar;
            Divisas_Negocio_Euro = divisas_Negocio_Euro;
            Divisas_Negocio_Canadiense = divisas_Negocio_Canadiense;
            Dolar_Compra = dolar_Compra;
            Dolar_Venta = dola_Venta;
            Canadiense_Compra = canadiense_Compra;
            Canadiense_Venta = canadiense_Venta;
            Euro_Compra = euro_Compra;
            Euro_Venta = euro_Venta;
            Imagen_Dolar = imagen_Dolar;
            Imagen_Canadiense = imagen_Canadiense;
            Imagen_Euro = imagen_Euro;
        }
    }
}
