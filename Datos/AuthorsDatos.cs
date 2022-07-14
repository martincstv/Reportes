using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Entidades;
using System.Data;
using System.Data.SqlClient;

namespace Datos
{
    public static class AuthorsDatos
    {
        public static List<AuthorsEntidades> ListaStates()
        {
            try
            {
                List<AuthorsEntidades> listaStates = new List<AuthorsEntidades>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT DISTINCT(state)
                                      FROM authors";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        AuthorsEntidades author = new AuthorsEntidades();
                        author.State = dr["state"].ToString();
                        listaStates.Add(author);
                    }
                }
                conexion.Close();
                return listaStates;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
