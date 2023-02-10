using DataAccess.Connection;
using DataAccess.Contratos;
using Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositorys
{
    public class DEncuesta_Datos_Divisas : IEncuesta_Datos_Divisas
    {
        private ConnectionDB _conn = new ConnectionDB();
        private SqlCommand Cmd = new SqlCommand();
        private SqlDataReader DReader;
        private List<Encuesta_Datos_Divisas>_Ledd=new List<Encuesta_Datos_Divisas>();
        public void Agregar(Encuesta_Datos_Divisas _Edd)
        {
            throw new NotImplementedException();
        }

        public List<Encuesta_Datos_Divisas> Consultar(string F_Encuesta)
        {
            string query = $"SP_Supervision_Encuesta_Datos";
            try
            {
                Cmd.CommandText = query;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_Encuesta", 2423);
                Cmd.Parameters.AddWithValue("@Fecha", F_Encuesta);
                Cmd.Connection = _conn.AbrirConexion();
                DReader = Cmd.ExecuteReader();
                while (DReader.Read())
                {
                    _Ledd.Add(
                        new Encuesta_Datos_Divisas()
                        {
                            Id_Encuesta_Contestada = Convert.ToInt32(DReader["Id_Encuesta_Contestada"]),
                            Id_Encuesta = Convert.ToInt32(DReader["Id_Encuesta"]),
                            Folio_Encuesta = DBNull.Value.Equals(DReader["Folio_Encuesta"]) ? "Sin Folio" : DReader["Folio_Encuesta"].ToString(),
                            Fecha_Hora_Inicio = DBNull.Value.Equals(DReader["Fecha_Hora_Inicio"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Inicio"]),
                            Fecha_Hora_Fin = DBNull.Value.Equals(DReader["Fecha_Hora_Fin"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Fin"]),
                            Id_Usuario = DBNull.Value.Equals(DReader["Id_Usuario"]) ? "" : DReader["Id_Usuario"].ToString(),
                            Estatus_Encuesta = DBNull.Value.Equals(DReader["Estatus_Encuesta"]) ? "" : DReader["Estatus_Encuesta"].ToString(),
                            Completa = DBNull.Value.Equals(DReader["Completa"]) ? 0 : Convert.ToInt32(DReader["Completa"]),
                            Fecha_Registro = DBNull.Value.Equals(DReader["Fecha_Registro"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Registro"]),
                            Activa = DBNull.Value.Equals(DReader["Activa"]) ? 0 : Convert.ToInt32(DReader["Activa"]),
                            Version_App = DBNull.Value.Equals(DReader["Version_App"]) ? "Error en Version de la App" : DReader["Version_App"].ToString(),
                            Duracion_Seg= DBNull.Value.Equals(DReader["Duracion_Seg"]) ? 0 : Convert.ToInt32(DReader["Duracion_Seg"]),
                            Sucursal_Banco_Azteca= DBNull.Value.Equals(DReader["Sucursal_Banco_Azteca"]) ? "" : DReader["Sucursal_Banco_Azteca"].ToString(),
                            Incidencia= DBNull.Value.Equals(DReader["Incidencia"]) ? "" : DReader["Incidencia"].ToString(),
                            Tipo_Incidencia= DBNull.Value.Equals(DReader["Tipo_Incidencia"]) ? "" : DReader["Tipo_Incidencia"].ToString(),
                            Foto_incidencia = DBNull.Value.Equals(DReader["foto_incidencia"]) ? "" : DReader["foto_incidencia"].ToString(),
                            Negocio_Competencia= DBNull.Value.Equals(DReader["negocio_competencia"]) ? "" : DReader["negocio_competencia"].ToString(),
                            Geolocalizacion= DBNull.Value.Equals(DReader["geolocalizacion"]) ? "" : DReader["geolocalizacion"].ToString(),
                            Divisas_Negocio_Dolar= DBNull.Value.Equals(DReader["divisas_negocio_divisa_dolar"]) ? 0 : Convert.ToInt32(DReader["divisas_negocio_divisa_dolar"]),
                            Divisas_Negocio_Euro= DBNull.Value.Equals(DReader["divisas_negocio_divisa_euro"]) ? 0 : Convert.ToInt32(DReader["divisas_negocio_divisa_euro"]),
                            Divisas_Negocio_Canadiense= DBNull.Value.Equals(DReader["divisas_negocio_divisa_canadiense"]) ? 0 : Convert.ToInt32(DReader["divisas_negocio_divisa_canadiense"]),
                            Dolar_Compra= DBNull.Value.Equals(DReader["Dolar_Compra"]) ? "" : DReader["Dolar_Compra"].ToString(),
                            Dolar_Venta= DBNull.Value.Equals(DReader["Dolar_Venta"]) ? "" : DReader["Dolar_Venta"].ToString(),
                            Canadiense_Compra= DBNull.Value.Equals(DReader["Canadiense_Compra"]) ? "" : DReader["Canadiense_Compra"].ToString(),
                            Canadiense_Venta= DBNull.Value.Equals(DReader["Canadiense_Venta"]) ? "" : DReader["Canadiense_Venta"].ToString(),
                            Euro_Compra= DBNull.Value.Equals(DReader["Euro_Compra"]) ? "" : DReader["Euro_Compra"].ToString(),
                            Euro_Venta= DBNull.Value.Equals(DReader["Euro_Venta"]) ? "" : DReader["Euro_Venta"].ToString(),
                            Imagen_Dolar= DBNull.Value.Equals(DReader["imagen_dolar"]) ? "" : DReader["imagen_dolar"].ToString(),
                            Imagen_Canadiense= DBNull.Value.Equals(DReader["imagen_canadiense"]) ? "" : DReader["imagen_canadiense"].ToString(),
                            Imagen_Euro= DBNull.Value.Equals(DReader["imagen_euro"]) ? "" : DReader["imagen_euro"].ToString(),
                        });
                }
                _conn.CerrarConexion();
                return _Ledd;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
            finally
            {
                _conn.CerrarConexion();
            }
        }

        public Encuesta_Datos_Divisas Conulta(int id)
        {
            throw new NotImplementedException();
        }

        public void Editar(Encuesta_Datos_Divisas _Edd)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }
    }
}
