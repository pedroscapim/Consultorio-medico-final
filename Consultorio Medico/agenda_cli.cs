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
    public partial class agenda_cli : Form
    {
        public agenda_cli()
        {
            InitializeComponent();
        }


    
        agendaENT objtabela = new agendaENT();



        private void limparcampo()
        {
            txtdata.Clear();
            txtespecialidade.Clear();
            txthorario.Clear();
            txtidagenda.Clear();
            txtidcliente.Clear();
            txtmedico.Clear();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            objtabela.ID_Cliente = Convert.ToInt32(txtidcliente.Text);
            objtabela.medico = txtmedico.Text;
            objtabela.especialidade = txtespecialidade.Text;
            objtabela.data = Convert.ToDateTime(txtdata.Text);
            objtabela.horario = txthorario.Text;

            int x = agendaMODEL.Inserir(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario agendado!"));

            }
            else
            {
                MessageBox.Show("Não foi Inserido!");
            }
            ListarGride();
            limparcampo();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                objtabela.ID_Cliente = Convert.ToInt32(txtidcliente.Text);
                objtabela.medico = Convert.ToString(txtmedico.Text);
                objtabela.especialidade = Convert.ToString(txtespecialidade.Text);
                objtabela.data = Convert.ToDateTime(txtdata.Text);
                objtabela.horario = Convert.ToString(txthorario.Text);

                int x = agendaMODEL.Alterar(objtabela);

                if (x > 0)
                {
                    MessageBox.Show(string.Format("O Agendamento foi Alterado"));

                }
                else
                {
                    MessageBox.Show("Não alterado!");
                }
               
                ListarGride();
                limparcampo();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void ListarGrid()
        {
            try
            {
                List<agendaENT> lista = new List<agendaENT>();
                lista = new agendaMODEL().Lista();
                grid1.AutoGenerateColumns = false;
                grid1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void ListarGride()
        {
            try
            {
                //cria uma lista 
                List<agendaENT> lista = new List<agendaENT>();
                lista = new agendaMODEL().Lista();
                grid1.AutoGenerateColumns = false;
                //grid data source receb os dados que vem da lista 
                grid1.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }


        private void agenda_cli_Load(object sender, EventArgs e)
        {
            ListarGride();
        }

        private void grid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtidagenda.Text = grid1.CurrentRow.Cells[0].Value.ToString();
            txtidcliente.Text = grid1.CurrentRow.Cells[1].Value.ToString();
            txtmedico.Text = grid1.CurrentRow.Cells[2].Value.ToString();
            txtespecialidade.Text = grid1.CurrentRow.Cells[3].Value.ToString();
            txtdata.Text = grid1.CurrentRow.Cells[4].Value.ToString();
            txthorario.Text = grid1.CurrentRow.Cells[5].Value.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                objtabela.id = Convert.ToInt32(txtidagenda.Text);
                objtabela.ID_Cliente = Convert.ToInt32(txtidcliente.Text);
                objtabela.medico = Convert.ToString(txtmedico.Text);
                objtabela.especialidade = Convert.ToString(txtespecialidade.Text);
                objtabela.data = Convert.ToDateTime(txtdata.Text);
                objtabela.horario = Convert.ToString(txthorario.Text);

                int x = agendaMODEL.Deletar(objtabela);
                if (x > 0)
                {
                    MessageBox.Show(string.Format("agendamento foi Deletado"));

                }
                else
                {
                    MessageBox.Show("Não alterado!");
                    ListarGrid();
                    

                }
                ListarGride();
                limparcampo();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}

