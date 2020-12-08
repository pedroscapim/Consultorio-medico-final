using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Consultorio_Medico.Entidades;

namespace Consultorio_Medico.DAO
{
    class sintomaDAO
    {
        internal int Salvar(sintomaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "INSERT INTO sintoma ([ID_Cli],[ALERGIA],[PROBLEMA_DE_SAUDE],[OBSERVAÇÃO],[RECEITA],[DATA]) VALUES (@ID_Cli, @ALERGIA, @PROBLEMA_DE_SAUDE, @OBSERVAÇÃO, @RECEITA, @DATA)";
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID;
                cn.Parameters.Add("ALERGIA", SqlDbType.VarChar).Value = objtabela.alergia;
                cn.Parameters.Add("PROBLEMA_DE_SAUDE", SqlDbType.VarChar).Value = objtabela.problema;
                cn.Parameters.Add("OBSERVAÇÃO", SqlDbType.VarChar).Value = objtabela.observacao;
                cn.Parameters.Add("RECEITA", SqlDbType.VarChar).Value = objtabela.receita;
                cn.Parameters.Add("DATA", SqlDbType.Date).Value = objtabela.data;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }



        }

        internal List<sintomaENT> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "SELECT ID_Cli, ALERGIA, PROBLEMA_DE_SAUDE, OBSERVAÇÃO, RECEITA, DATA FROM sintoma ";
                cn.Connection = con;
                SqlDataReader dr;
                List<sintomaENT> lista = new List<sintomaENT>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        sintomaENT dado = new sintomaENT();
                        dado.ID = Convert.ToInt32(dr["ID_Cli"]);
                        dado.alergia = Convert.ToString(dr["ALERGIA"]);
                        dado.problema = Convert.ToString(dr["PROBLEMA_DE_SAUDE"]);
                        dado.observacao = Convert.ToString(dr["OBSERVAÇÃO"]);
                        dado.receita = Convert.ToString(dr["RECEITA"]);
                        dado.data = Convert.ToDateTime(dr["DATA"]);


                        lista.Add(dado);

                    }
                }
                return lista;
            }
        }
    }
}

