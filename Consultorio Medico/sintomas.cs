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
    public partial class sintomas : Form
    {
        public sintomas()
        {
            InitializeComponent();
        }

        sintomaENT objtabela = new sintomaENT();

        private void limparcampos()
        {
            txtALERGIA.Clear();
            txtDATA.Clear();
            txtID.Clear();
            txtOBS.Clear();
            txtPROBLEMA.Clear();
            txtRECEITA.Clear();
        }



        private void btnsalvar_Click(object sender, EventArgs e)
        {
            objtabela.ID = Convert.ToInt32(txtID.Text);
            objtabela.alergia = txtALERGIA.Text;
            objtabela.problema = txtPROBLEMA.Text;
            objtabela.observacao = txtOBS.Text;
            objtabela.receita = txtRECEITA.Text;
            objtabela.data = Convert.ToDateTime(txtDATA.Text);


            int x = sintomaMODEL.Salvar(objtabela);

            if (x > 0)
            {
                MessageBox.Show(string.Format("Usuario Diagnosticado"));
            }
            else
            {
                MessageBox.Show("Operação deu falha");
            }
            limparcampos();
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            limparcampos();
        }
    }
}
