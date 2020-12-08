using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlTypes;

namespace Consultorio_Medico.Entidades
{
    class agendaENT
    {
        private int ID_agenda;
        private int ID_Cli;
        private string Medico;
        private string Especialidade;
        private DateTime Data;
        private string Horario;

        public int id { get => ID_agenda; set => ID_agenda = value; }
        public int ID_Cliente { get => ID_Cli; set => ID_Cli = value; }
        public string medico { get => Medico; set => Medico = value; }
        public string especialidade { get => Especialidade; set => Especialidade = value; }
        public DateTime data { get => Data; set => Data = value; }
        public string horario { get => Horario; set => Horario = value; }

    }
}
