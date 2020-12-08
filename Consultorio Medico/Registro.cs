using Consultorio_Medico.DAO;
using Consultorio_Medico.Entidades;
using Consultorio_Medico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Consultorio_Medico
{
    public partial class Registro : Form
    {

        sintomaENT objtabela = new sintomaENT();
       
        public Registro()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }


        private void Registro_Load(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source = PEDRAOPC\\MSSQLSERVER01; Initial Catalog = DB_CONSULT; Integrated Security=TRUE";
            string commandString = "SELECT * FROM sintoma WHERE ID_Cli LIKE @ID_Cli";

            SqlConnection ligacao = new SqlConnection(connectionString);
            SqlCommand comando = new SqlCommand(commandString, ligacao);

            comando.Parameters.AddWithValue("@ID_Cli", textBox1.Text);

            ligacao.Open();
            //define o tipo do comando
            comando.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(comando);

            DataTable sintoma = new DataTable();

            da.Fill(sintoma);

            dg1.DataSource = sintoma;

            comando.ExecuteNonQuery();


        }

        private void grid1_DataSourceChanged(object sender, EventArgs e)
        {

        }
    }
}
