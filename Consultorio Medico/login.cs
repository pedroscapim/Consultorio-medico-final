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
    public partial class login : Form
    {
        SqlConnection Conexao = new SqlConnection("Data Source = PEDRAOPC\\MSSQLSERVER01; Initial Catalog = DB_CONSULT; Integrated Security=True");
        public login()
        {
            InitializeComponent();
            txtlogin.Select();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Conexao.Open();
            string query = "SELECT * FROM usuario WHERE username = '"+txtlogin.Text+"'And senha ='"+txtsenha.Text+"'";
            SqlDataAdapter dp = new SqlDataAdapter(query, Conexao);
            DataTable dt = new DataTable();
            dp.Fill(dt);

            if (dt.Rows.Count == 1)
            {
                Form1 principal = new Form1();
                this.Hide();
                principal.Show();
            }
            else
            {
                MessageBox.Show("Usuario ou senha incorreto");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
