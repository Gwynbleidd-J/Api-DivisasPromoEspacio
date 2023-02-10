using DataAccess.Contratos;
using Entities;
using System;
using System.Collections.Generic;
using DataAccess.Connection;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.Repositorys
{
    public class DVista_S_Encuestas_Contestadas : IVista_S_Encuestas_Contestadas
    {
        private ConnectionDB _conn=new ConnectionDB();
        private SqlCommand Cmd=new SqlCommand();
        private SqlDataReader DReader;
        private List<Vista_S_Encuestas_Contestadas> _LVEC=new List<Vista_S_Encuestas_Contestadas>();
        private Vista_S_Encuestas_Contestadas _VEC=new Vista_S_Encuestas_Contestadas();
        public void Actualizar(Vista_S_Encuestas_Contestadas _VSECont)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Vista_S_Encuestas_Contestadas _VSECont)
        {
            throw new NotImplementedException();
        }

        public Vista_S_Encuestas_Contestadas Consultar(int id)
        {
            string query = $"SP_Get_Vista_Encuestas_Contesta_ID_Activas";
            try
            {
                Cmd.CommandText = query;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_Encuesta", id);
                Cmd.Connection = _conn.AbrirConexion();
                DReader = Cmd.ExecuteReader();
                while (DReader.Read())
                {
                    _VEC.Id_Encuesta = Convert.ToInt32(DReader["Id_Encuesta"]);
                    _VEC.Nombre_Encuesta = DBNull.Value.Equals(DReader["Nombre_Encuesta"]) ? "" : DReader["Nombre_Encuesta"].ToString();
                    _VEC.Fecha_Inicial = DBNull.Value.Equals(DReader["Fecha_Inicial"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Inicial"]);
                    _VEC.Fecha_Final = DBNull.Value.Equals(DReader["Fecha_Final"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Final"]);
                    _VEC.Fecha_Actualizacion = DBNull.Value.Equals(DReader["Fecha_Actualizacion"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Actualizacion"]);
                    _VEC.Id_Encuesta_Contestada = DBNull.Value.Equals(DReader["Id_Encuesta_Contestada"]) ? 0 : Convert.ToInt32(DReader["Id_Encuesta_Contestada"]);
                    _VEC.Folio_Encuesta = DBNull.Value.Equals(DReader["Folio_Encuesta"]) ? "Sin Folio" : DReader["Folio_Encuesta"].ToString();
                    _VEC.Fecha_Hora_Inicio = DBNull.Value.Equals(DReader["Fecha_Hora_Inicio"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Inicio"]);
                    _VEC.Fecha_Hora_Fin = DBNull.Value.Equals(DReader["Fecha_Hora_Fin"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Fin"]);
                    _VEC.Id_Usuario = DBNull.Value.Equals(DReader["Id_Usuario"]) ? "" : DReader["Id_Usuario"].ToString();
                    _VEC.Estatus_Encuestas = DBNull.Value.Equals(DReader["Estatus_Encuesta"]) ? "" : DReader["Estatus_Encuesta"].ToString();
                    _VEC.Activa = DBNull.Value.Equals(DReader["Activa"]) ? 0 : Convert.ToInt32(DReader["Activa"]);
                    _VEC.Completa = DBNull.Value.Equals(DReader["Completa"]) ? 0 : Convert.ToInt32(DReader["Completa"]);
                    _VEC.Fecha_Registro = DBNull.Value.Equals(DReader["Fecha_Registro"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Registro"]);
                    _VEC.Version_App = DBNull.Value.Equals(DReader["Version_App"]) ? "Error en Version de la App" : DReader["Version_App"].ToString();
                    _VEC.Nombre_Encuesta = DBNull.Value.Equals(DReader["Nombre_Usuario"]) ? "Error al buscar Nombre" : DReader["Nombre_Usuario"].ToString();
                }
                _conn.CerrarConexion();
                return _VEC;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _conn.CerrarConexion();
            }
        }

        public List<Vista_S_Encuestas_Contestadas> ConsultarV(int id)
        {
            string query = $"SP_Get_Vista_Encuestas_Contesta_ID_Activas";
            try
            {
                Cmd.CommandText = query;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_Encuesta", id);
                Cmd.Connection = _conn.AbrirConexion();
                DReader = Cmd.ExecuteReader();
                while (DReader.Read())
                {
                    _LVEC.Add(
                        new Vista_S_Encuestas_Contestadas()
                        {
                            Id_Encuesta = Convert.ToInt32(DReader["Id_Encuesta"]),
                            Nombre_Encuesta = DBNull.Value.Equals(DReader["Nombre_Encuesta"]) ? "" : DReader["Nombre_Encuesta"].ToString(),
                            Fecha_Inicial = DBNull.Value.Equals(DReader["Fecha_Inicial"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Inicial"]),
                            Fecha_Final = DBNull.Value.Equals(DReader["Fecha_Final"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Final"]),
                            Fecha_Actualizacion = DBNull.Value.Equals(DReader["Fecha_Actualizacion"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Actualizacion"]),
                            Id_Encuesta_Contestada = DBNull.Value.Equals(DReader["Id_Encuesta_Contestada"]) ? 0 : Convert.ToInt32(DReader["Id_Encuesta_Contestada"]),
                            Folio_Encuesta = DBNull.Value.Equals(DReader["Folio_Encuesta"]) ? "Sin Folio" : DReader["Folio_Encuesta"].ToString(),
                            Fecha_Hora_Inicio = DBNull.Value.Equals(DReader["Fecha_Hora_Inicio"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Inicio"]),
                            Fecha_Hora_Fin = DBNull.Value.Equals(DReader["Fecha_Hora_Fin"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Fin"]),
                            Id_Usuario= DBNull.Value.Equals(DReader["Id_Usuario"]) ? "" : DReader["Id_Usuario"].ToString(),
                            Estatus_Encuestas= DBNull.Value.Equals(DReader["Estatus_Encuesta"]) ? "" : DReader["Estatus_Encuesta"].ToString(),
                            Activa = DBNull.Value.Equals(DReader["Activa"]) ? 0 : Convert.ToInt32(DReader["Activa"]),
                            Completa = DBNull.Value.Equals(DReader["Completa"]) ? 0 : Convert.ToInt32(DReader["Completa"]),
                            Fecha_Registro = DBNull.Value.Equals(DReader["Fecha_Registro"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Registro"]),
                            Version_App = DBNull.Value.Equals(DReader["Version_App"]) ? "Error en Version de la App" : DReader["Version_App"].ToString(),
                            Nombre_Usuario = DBNull.Value.Equals(DReader["Nombre_Usuario"]) ? "Error al buscar Nombre" : DReader["Nombre_Usuario"].ToString(),
                        });
                }
                _conn.CerrarConexion();
                return _LVEC;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _conn.CerrarConexion();
            }
        }

        public List<Vista_S_Encuestas_Contestadas> ConsultarVF(int id, DateTime fecha_In, DateTime fecha_Fin)
        {
            string query = $"SP_Get_Vista_Encuestas_Contesta_ID_Fecha_Activas";
            try
            {
                Cmd.CommandText = query;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Parameters.AddWithValue("@id_Encuesta", id);
                Cmd.Parameters.AddWithValue("@fecha_In", fecha_In);
                Cmd.Parameters.AddWithValue("@fecha_fin", fecha_Fin);
                Cmd.Connection = _conn.AbrirConexion();
                DReader = Cmd.ExecuteReader();
                while (DReader.Read())
                {
                    _LVEC.Add(
                        new Vista_S_Encuestas_Contestadas()
                        {
                            Id_Encuesta = Convert.ToInt32(DReader["Id_Encuesta"]),
                            Nombre_Encuesta = DBNull.Value.Equals(DReader["Nombre_Encuesta"]) ? "" : DReader["Nombre_Encuesta"].ToString(),
                            Fecha_Inicial = DBNull.Value.Equals(DReader["Fecha_Inicial"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Inicial"]),
                            Fecha_Final = DBNull.Value.Equals(DReader["Fecha_Final"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Final"]),
                            Fecha_Actualizacion = DBNull.Value.Equals(DReader["Fecha_Actualizacion"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Actualizacion"]),
                            Id_Encuesta_Contestada = DBNull.Value.Equals(DReader["Id_Encuesta_Contestada"]) ? 0 : Convert.ToInt32(DReader["Id_Encuesta_Contestada"]),
                            Folio_Encuesta = DBNull.Value.Equals(DReader["Folio_Encuesta"]) ? "Sin Folio" : DReader["Folio_Encuesta"].ToString(),
                            Fecha_Hora_Inicio = DBNull.Value.Equals(DReader["Fecha_Hora_Inicio"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Inicio"]),
                            Fecha_Hora_Fin = DBNull.Value.Equals(DReader["Fecha_Hora_Fin"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Fin"]),
                            Id_Usuario = DBNull.Value.Equals(DReader["Id_Usuario"]) ? "" : DReader["Id_Usuario"].ToString(),
                            Estatus_Encuestas = DBNull.Value.Equals(DReader["Estatus_Encuesta"]) ? "" : DReader["Estatus_Encuesta"].ToString(),
                            Activa = DBNull.Value.Equals(DReader["Activa"]) ? 0 : Convert.ToInt32(DReader["Activa"]),
                            Completa = DBNull.Value.Equals(DReader["Completa"]) ? 0 : Convert.ToInt32(DReader["Completa"]),
                            Fecha_Registro = DBNull.Value.Equals(DReader["Fecha_Registro"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Registro"]),
                            Version_App = DBNull.Value.Equals(DReader["Version_App"]) ? "Error en Version de la App" : DReader["Version_App"].ToString(),
                            Nombre_Usuario = DBNull.Value.Equals(DReader["Nombre_Usuario"]) ? "Error al buscar Nombre" : DReader["Nombre_Usuario"].ToString(),
                        });
                }
                _conn.CerrarConexion();
                return _LVEC;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _conn.CerrarConexion();
            }
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vista_S_Encuestas_Contestadas> GetContestadas()
        {
            string query = $"SP_Get_Vista_S_Encuestas_Contesta_Activas";
            try
            {
                Cmd.CommandText = query;
                Cmd.CommandType = CommandType.StoredProcedure;
                Cmd.Connection = _conn.AbrirConexion();
                DReader = Cmd.ExecuteReader();
                while (DReader.Read())
                {
                    _LVEC.Add(
                        new Vista_S_Encuestas_Contestadas()
                        {
                            Id_Encuesta = Convert.ToInt32(DReader["Id_Encuesta"]),
                            Nombre_Encuesta= DBNull.Value.Equals(DReader["Nombre_Encuesta"]) ? "" : DReader["Nombre_Encuesta"].ToString(),
                            Fecha_Inicial = DBNull.Value.Equals(DReader["Fecha_Inicial"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Inicial"]),
                            Fecha_Final= DBNull.Value.Equals(DReader["Fecha_Final"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Final"]),
                            Fecha_Actualizacion= DBNull.Value.Equals(DReader["Fecha_Actualizacion"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Actualizacion"]),
                            Id_Encuesta_Contestada= DBNull.Value.Equals(DReader["Id_Encuesta_Contestada"]) ? 0 : Convert.ToInt32(DReader["Id_Encuesta_Contestada"]),
                            Folio_Encuesta= DBNull.Value.Equals(DReader["Folio_Encuesta"]) ? "Sin Folio" : DReader["Folio_Encuesta"].ToString(),
                            Fecha_Hora_Inicio= DBNull.Value.Equals(DReader["Fecha_Hora_Inicio"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Inicio"]),
                            Fecha_Hora_Fin= DBNull.Value.Equals(DReader["Fecha_Hora_Fin"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Hora_Fin"]),
                            Id_Usuario = DBNull.Value.Equals(DReader["Id_Usuario"]) ? "" : DReader["Id_Usuario"].ToString(),
                            Estatus_Encuestas = DBNull.Value.Equals(DReader["Estatus_Encuesta"]) ? "" : DReader["Estatus_Encuesta"].ToString(),
                            Activa = DBNull.Value.Equals(DReader["Activa"]) ? 0 : Convert.ToInt32(DReader["Activa"]),
                            Completa= DBNull.Value.Equals(DReader["Completa"]) ? 0 : Convert.ToInt32(DReader["Completa"]),
                            Fecha_Registro= DBNull.Value.Equals(DReader["Fecha_Registro"]) ? Convert.ToDateTime("2022-01-01") : Convert.ToDateTime(DReader["Fecha_Registro"]),
                            Version_App= DBNull.Value.Equals(DReader["Version_App"]) ? "Error en Version de la App" : DReader["Version_App"].ToString(),
                            Nombre_Usuario= DBNull.Value.Equals(DReader["Nombre_Usuario"]) ? "Error al buscar Nombre" : DReader["Nombre_Usuario"].ToString(),
                        });
                }
                _conn.CerrarConexion();
                return _LVEC;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                _conn.CerrarConexion();
            }
        }
    }
}
