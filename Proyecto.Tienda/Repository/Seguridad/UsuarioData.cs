using Proyecto.Tienda.DataC;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using Tienda.Domain.Seguridad;

namespace Proyecto.Tienda.Repository.Seguridad
{
    public class UsuarioData
    {

        public static List<BEUsuario> Listado()
        {
            List<BEUsuario> oListaUsuario = new List<BEUsuario>();
            using (SqlConnection oConection = new SqlConnection(Conexion.rutaConeccion))
            {
                SqlCommand cmd = new SqlCommand("[seguridad].[usp_app_listado_usuarios]", oConection);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConection.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while(dr.Read())
                        {
                            oListaUsuario.Add(new BEUsuario()
                            {
                                nro = int.Parse(dr["nro"].ToString()),
                                usuarioNombre = dr["usuarioNombre"].ToString(),
                                usuarioApellido = dr["usuarioApellido"].ToString(),
                                usuarioDireccion = dr["usuarioDireccion"].ToString(),
                                usuarioDNI = dr["usuarioDNI"].ToString(),
                                usuarioPasssword = dr["usuarioPasssword"].ToString()
                        });
                        }
                    }
                    return oListaUsuario;
                }
                catch (Exception ex)
                {
                    return oListaUsuario;
                }
            }
        }
    }
}