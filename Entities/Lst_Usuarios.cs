using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct Lst_Usuarios
    {
        public string Id_Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Nombre_Usuario { get; set; }
        public string Empleado { get; set; }
        public int Id_RazonSacial { get; set; }
        public int Tipo_Cliente { get; set; }
        public string RFC { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Ciudad { get; set; }
        public string Colonia { get; set; }
        public string Calle { get; set; }
        public string Numero { get; set; }
        public string Telefono { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int Tipo_Usuario { get; set; }
        public string Usuario_Registro { get; set; }
        public DateTime Fecha_Registro { get; set; }
        public int Activo { get; set; }
        public int Id_DatosFiscales { get; set; }
        public string Estatus { get; set; }
        public string Denominacionn { get; set; }
        public string Apoyo_Externo { get; set; }
        public int Porcentaje_Avance { get; set; }
        public float Inversion_Estimada { get; set; }
        public float Inversion_Estimada_FA { get; set; }
        public float Inversion_Estimada_LIV { get; set; }
        public float Inversion_Estimada_CC { get; set; }
        public float Inversion_Estimada_VIPS { get; set; }
        public string Sector { get; set; }
        public string Estatus_Inversion { get; set; }
        public DateTime Fecha_PosibleCierre { get; set; }
        public DateTime Fecha_PosibleInicioCampana { get; set; }
        public DateTime Fecha_SiguienteAccion { get; set; }
        public string Cuenta { get; set; }
        public int Standby { get; set; }
        public int Comisiona { get; set; }
        public string Prospectando { get; set; }
        public DateTime Fecha_Antiguedad { get; set; }
        public DateTime Fecha_Cumpleanios { get; set; }
        public string Tipo_Zona { get; set; }
        public string Tipo_Clasificacion { get; set; }
        public DateTime Actualizacion_Password { get; set; }
        public string Token { get; set; }
        public string UIPE { get; set; }
        public float Inversion_Estimada_AICM { get; set; }
        public float Inversion_Estimada_SENDERO { get; set; }
        public float Inversion_Estimada_IMSS { get; set; }
        public float Inversion_Estimada_CASINOS { get; set; }
        public float Inversion_Estimada_ISSSTE { get; set; }
        public float Inversion_Estimada_MARTI { get; set; }
        public float Inversion_Estimada_UVM { get; set; }
        public float Inversion_Estimada_CDT { get; set; }
        public float Inversion_Estimada_NETO { get; set; }
        public string ColorBanner { get; set; }
        public int Nuevo_Tipo_Cliente { get; set; }
        public string Contrasena_New_Encrypt { get; set; }

        public Lst_Usuarios(string id_Usuario,string contraseña,string nombre_Usuario,string empleado,int id_Razonsocial,int tipo_Cliente,string rfc,
            string pais,string estado,string ciudad,string colonia,string calle,string numero,string telefono,string celular,string correo,int tipo_usuario,
            string usuario_registro,DateTime fecha_registro,int activo,int id_datosFiscales,string estatus,string denominacion,string apoyo_externo,
            int porcentaje_Avance,float inversion_Estimada,float inversion_Estimada_FA,float inversion_Estimada_LIV,float inversion_Estimada_CC,
            float inversion_Estimada_VIPS, string sector,string estatus_Inversion,DateTime fecha_PosibleCierre,DateTime fecha_PosibleInicioCampana,
            DateTime fecha_SiguienteAccion,string cuenta,int standby,int comisiona,string prospectando, DateTime fecha_Antiguedad, DateTime fecha_Cumpleanios,
            string tipo_zona,string tipo_calificacion,DateTime actualizacion_Password,string token,string uipe,float inversion_Estimada_AICM,
            float inversion_Estimada_SENDERO, float inversion_Estimada_IMSS,float inversion_Estimada_CASINOS, float inversion_Estimada_ISSSTE, 
            float inversion_Estimada_MARTI, float inversion_Estimada_UVM, float inversion_Estimada_CDT, float inversion_Estimada_NETO,
            string colorBanner, int nuevo_Tipo_Cliente, string contrasena_New_Encrypt)
        {
            Id_Usuario = id_Usuario;
            Contraseña = contraseña;
            Nombre_Usuario=nombre_Usuario;
            Empleado = empleado;
            Id_RazonSacial = id_Razonsocial;
            Tipo_Cliente= tipo_Cliente;
            RFC = rfc;
            Pais= pais;
            Estado= estado;
            Ciudad = ciudad;
            Colonia= colonia;
            Calle= calle;
            Numero= numero;
            Telefono= telefono;
            Celular= celular;
            Correo= correo;
            Tipo_Usuario = tipo_usuario;
            Usuario_Registro = usuario_registro;
            Fecha_Registro= fecha_registro;
            Activo= activo;
            Id_DatosFiscales = id_datosFiscales;
            Estatus = estatus;
            Denominacionn = denominacion;
            Apoyo_Externo= apoyo_externo;
            Porcentaje_Avance= porcentaje_Avance;
            Inversion_Estimada= inversion_Estimada;
            Inversion_Estimada_FA = inversion_Estimada_FA;
            Inversion_Estimada_LIV= inversion_Estimada_LIV;
            Inversion_Estimada_CC= inversion_Estimada_CC;
            Inversion_Estimada_VIPS= inversion_Estimada_VIPS;
            Sector=sector;
            Estatus_Inversion = estatus_Inversion;
            Fecha_PosibleCierre = fecha_PosibleCierre;
            Fecha_PosibleInicioCampana = fecha_PosibleInicioCampana;
            Fecha_SiguienteAccion=fecha_SiguienteAccion;
            Cuenta = cuenta;
            Standby = standby;
            Comisiona= comisiona;
            Prospectando= prospectando;
            Fecha_Antiguedad=fecha_Antiguedad;
            Fecha_Cumpleanios=fecha_Cumpleanios;
            Tipo_Zona = tipo_zona;
            Tipo_Clasificacion = tipo_calificacion;
            Actualizacion_Password = actualizacion_Password;
            Token= token;
            UIPE = uipe;
            Inversion_Estimada_AICM= inversion_Estimada_AICM;
            Inversion_Estimada_SENDERO= inversion_Estimada_SENDERO;
            Inversion_Estimada_IMSS= inversion_Estimada_IMSS;
            Inversion_Estimada_CASINOS=inversion_Estimada_CASINOS;
            Inversion_Estimada_ISSSTE= inversion_Estimada_ISSSTE;
            Inversion_Estimada_MARTI= inversion_Estimada_MARTI;
            Inversion_Estimada_UVM= inversion_Estimada_UVM;
            Inversion_Estimada_CDT= inversion_Estimada_CDT;
            Inversion_Estimada_NETO= inversion_Estimada_NETO;
            ColorBanner = colorBanner;
            Nuevo_Tipo_Cliente= nuevo_Tipo_Cliente;
            Contrasena_New_Encrypt= contrasena_New_Encrypt;
        }


    }
}
