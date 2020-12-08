using Consultorio_Medico.Entidades;
using Consultorio_Medico.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Consultorio_Medico
{
    public partial class cad_cli : Form
    {
        public cad_cli()
        {
            InitializeComponent();
        }


        clienteENT objtabela = new clienteENT();

        private void limparcampos ()
        {
            txtID.Clear();
            txtNOME.Clear();
            txtCEP.Clear();
            txtCPF.Clear();
            txtCELULAR.Clear();
            txtCONVENIO.Clear();
            txtIDADE.Clear();
            txtENDERECO.Clear();
            txtSEXO.Clear();
            txtTELEFONE.Clear();
            txtNOME.Focus();
                    
        }




        private void button1_Click(object sender, EventArgs e)
        {
            objtabela.nome = txtNOME.Text;
            objtabela.cpf = txtCPF.Text;
            objtabela.idade = Convert.ToInt32(txtIDADE.Text);
            objtabela.endereco = txtENDERECO.Text;
            objtabela.telefone = txtTELEFONE.Text;
            objtabela.convenio = txtCONVENIO.Text;
            objtabela.sexo = txtSEXO.Text;
            objtabela.cep = txtCEP.Text;
            objtabela.celular = txtCELULAR.Text;

            int x = clienteMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario {0} foi Inserido", txtNOME.Text));

            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
                ListarGrid();
                txtID.Clear();
                txtNOME.Clear();
                txtCEP.Clear();
                txtCPF.Clear();
                txtCELULAR.Clear();
                txtCONVENIO.Clear();
                txtENDERECO.Clear();
                txtIDADE.Clear();
                txtSEXO.Clear();
                txtTELEFONE.Clear();
            }
            ListarGrid();
            limparcampos();



        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objtabela.ID = Convert.ToInt32(txtID.Text);
                objtabela.nome = txtNOME.Text;
                objtabela.cpf = txtCPF.Text;
                objtabela.idade = Convert.ToInt32(txtIDADE.Text);
                objtabela.endereco = txtENDERECO.Text;
                objtabela.telefone = txtTELEFONE.Text;
                objtabela.convenio = txtCONVENIO.Text;
                objtabela.sexo = txtSEXO.Text;
                objtabela.cep = txtCEP.Text;
                objtabela.celular = txtCELULAR.Text;

                int x = clienteMODEL.Alterar(objtabela);
                if (x > 0)
                {
                    MessageBox.Show(string.Format("Usuario {0} foi Alterado", txtNOME.Text));

                }
                else
                {
                    MessageBox.Show("Não alterado!");


                }
                ListarGrid();
                limparcampos();

            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void cad_cli_Load(object sender, EventArgs e)
        {
            ListarGrid();
           
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtID.Text = grid20.CurrentRow.Cells[0].Value.ToString();
            txtNOME.Text = grid20.CurrentRow.Cells[1].Value.ToString();
            txtCPF.Text = grid20.CurrentRow.Cells[2].Value.ToString();
            txtCONVENIO.Text = grid20.CurrentRow.Cells[3].Value.ToString();
            txtIDADE.Text = grid20.CurrentRow.Cells[4].Value.ToString();
            txtSEXO.Text = grid20.CurrentRow.Cells[5].Value.ToString();
            txtENDERECO.Text = grid20.CurrentRow.Cells[6].Value.ToString();
            txtTELEFONE.Text = grid20.CurrentRow.Cells[7].Value.ToString();
            txtCELULAR.Text = grid20.CurrentRow.Cells[8].Value.ToString();
            txtCEP.Text = grid20.CurrentRow.Cells[9].Value.ToString();
        }
        private void ListarGrid()
        {
            try
            {
                //cria uma lista 
                List<clienteENT> lista = new List<clienteENT>();
                lista = new clienteMODEL().Lista();
                grid20.AutoGenerateColumns = false;
                grid20.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                objtabela.ID = Convert.ToInt32(txtID.Text);
                objtabela.nome = txtNOME.Text;
                objtabela.cpf = txtCPF.Text;
                objtabela.idade = Convert.ToInt32(txtIDADE.Text);
                objtabela.endereco = txtENDERECO.Text;
                objtabela.telefone = txtTELEFONE.Text;
                objtabela.convenio = txtCONVENIO.Text;
                objtabela.sexo = txtSEXO.Text;
                objtabela.cep = txtCEP.Text;
                objtabela.celular = txtCELULAR.Text;

                int x = clienteMODEL.Deletar(objtabela);
                if (x > 0)
                {
                    MessageBox.Show(string.Format("Usuario {0} foi Deletado", txtNOME.Text));

                }
                else
                {
                    MessageBox.Show("Não alterado!");
                }
                ListarGrid();
                limparcampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
 

}

