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
    public static class TitlesDatos
    {
        public static List<TitlesEntidades> ListaTitles()
        {
            try
            {
                List<TitlesEntidades> listaTitles = new List<TitlesEntidades>();

                SqlConnection conexion = new SqlConnection(Properties.Settings.Default.conexionBD);
                conexion.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conexion;
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = @"SELECT DISTINCT(type)
                                      FROM titles";
                using (var dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        TitlesEntidades title = new TitlesEntidades();
                        title.Type = dr["type"].ToString();
                        listaTitles.Add(title);
                    }
                }
                conexion.Close();
                return listaTitles;
            }
            catch (Exception e)
            {
                var error = e.Message;
                throw;
            }
        }
    }
}
