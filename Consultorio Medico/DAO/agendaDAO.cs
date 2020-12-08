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
    class agendaDAO
    {
        internal int Inserir(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "INSERT INTO agendacli ([ID_Cli],[Medico],[Especialidade],[Data],[Horario]) VALUES (@ID_Cli, @Medico, @Especialidade, @Data, @Horario)";
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID_Cliente;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.Date).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.VarChar).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        internal int Alterar(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();


                cn.CommandText = "UPDATE agendacli SET ID_Cli =@ID_Cli, Medico=@Medico, Especialidade = @Especialidade, Data=@Data, Horario=@Horario ";
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID_Cliente;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.Date).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.VarChar).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }
        }

        internal List<agendaENT> Lista()
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "SELECT ID_agenda,ID_Cli,Medico,Especialidade,Data,Horario FROM agendacli";
                cn.Connection = con;
                SqlDataReader dr;
                List<agendaENT> lista = new List<agendaENT>();
                dr = cn.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        agendaENT dado = new agendaENT();
                        dado.id = Convert.ToInt32(dr["ID_agenda"]);
                        dado.ID_Cliente = Convert.ToInt32(dr["ID_Cli"]);
                        dado.medico = Convert.ToString(dr["Medico"]);
                        dado.especialidade = Convert.ToString(dr["Especialidade"]);
                        dado.data = Convert.ToDateTime(dr["Data"]);
                        dado.horario = Convert.ToString(dr["Horario"]);

                        lista.Add(dado);

                    }
                }
                return lista;

            }

        }

        internal int Deletar(agendaENT objtabela)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = Properties.Settings.Default.Banco;
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                con.Open();

                cn.CommandText = "DELETE FROM agendacli WHERE ID_agenda=@ID_agenda";
                cn.Parameters.Add("ID_agenda", SqlDbType.Int).Value = objtabela.id;
                cn.Parameters.Add("ID_Cli", SqlDbType.Int).Value = objtabela.ID_Cliente;
                cn.Parameters.Add("Medico", SqlDbType.VarChar).Value = objtabela.medico;
                cn.Parameters.Add("Especialidade", SqlDbType.VarChar).Value = objtabela.especialidade;
                cn.Parameters.Add("Data", SqlDbType.Date).Value = objtabela.data;
                cn.Parameters.Add("Horario", SqlDbType.VarChar).Value = objtabela.horario;

                cn.Connection = con;

                int qtd = cn.ExecuteNonQuery();
                return qtd;
            }





        }
    }
}
