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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cadastroDeClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cad_cli = new cad_cli();
            cad_cli.Show();
        }

        private void agendaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form agenda_cli = new agenda_cli();
            agenda_cli.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void sintomasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form sintomas = new sintomas();
            sintomas.Show();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Registro = new Registro();
            Registro.Show();
        }

        private void medicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Medico = new Medico();
            Medico.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
