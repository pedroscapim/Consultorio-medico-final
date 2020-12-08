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

namespace Consultorio_Medico
{
    public partial class Medico : Form
    {
        public Medico()
        {
            InitializeComponent();
        }

        medicoENT objtabela = new medicoENT();
        
        private void limparcampos()
        {
            txtcpf.Clear();
            txtcrm.Clear();
            txtespecialidade.Clear();
            txtID.Clear();
            txtidade.Clear();
            txtnome.Clear();
        }
        
        
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Medico_Load(object sender, EventArgs e)
        {
            listargrid();
        }

        private void btnINSERIR_Click(object sender, EventArgs e)
        {
            objtabela.nome = txtnome.Text;
            objtabela.idade = Convert.ToInt32(txtidade.Text);
            objtabela.crm = txtcrm.Text;
            objtabela.cpf = txtcpf.Text;
            objtabela.especialidade = txtespecialidade.Text;

            int x = medicoMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Medico Cadastrado"));

            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }
            listargrid();
            limparcampos();
        }

        private void btnALTERAR_Click(object sender, EventArgs e)
        {
            try
            {
                objtabela.id = Convert.ToInt32(txtID.Text);
                objtabela.nome = Convert.ToString(txtnome.Text);
                objtabela.idade = Convert.ToInt32(txtidade.Text);
                objtabela.crm = Convert.ToString(txtcrm.Text);
                objtabela.cpf = Convert.ToString(txtcpf.Text);
                objtabela.especialidade = Convert.ToString(txtespecialidade.Text);

                int x = medicoMODEL.Alterar(objtabela);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("Alterado"));

                }
                else
                {
                    MessageBox.Show("Não alterado!");
                }
                listargrid();
                limparcampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grid1.CurrentRow.Cells[0].Value.ToString();
            txtnome.Text = grid1.CurrentRow.Cells[1].Value.ToString();
            txtidade.Text = grid1.CurrentRow.Cells[2].Value.ToString();
            txtcrm.Text = grid1.CurrentRow.Cells[3].Value.ToString();
            txtcpf.Text = grid1.CurrentRow.Cells[4].Value.ToString();
            txtespecialidade.Text = grid1.CurrentRow.Cells[5].Value.ToString();
        }

        private void listargrid()
        {
            try
            {
                List<medicoENT> lista = new List<medicoENT>();
                lista = new medicoMODEL().Lista();
                grid1.AutoGenerateColumns = false;
                grid1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void btnEXCLUIR_Click(object sender, EventArgs e)
        {
            try
            {
                
               
                objtabela.id = Convert.ToInt32(txtID.Text);
                objtabela.nome = Convert.ToString(txtnome.Text);
                objtabela.idade = Convert.ToInt32(txtidade.Text);
                objtabela.crm = Convert.ToString(txtcrm.Text);
                objtabela.cpf = Convert.ToString(txtcpf.Text);
                objtabela.especialidade = Convert.ToString(txtcpf.Text);

                int x = medicoMODEL.Deletar(objtabela);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("O Agendamento foi Alterado"));

                }
                else
                {
                    MessageBox.Show("Não alterado!");
                }
                listargrid();
                limparcampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

