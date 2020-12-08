using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_Medico.Entidades
{
    class sintomaENT
    {
        private int ID_sintoma;
        private int ID_Cli;
        private string ALERGIA;
        private string PROBLEMA_DE_SAUDE;
        private string OBSERVAÇÃO;
        private string RECEITA;
        private DateTime DATA;

        public int id { get => ID_sintoma; set => ID_sintoma = value; }
        public int ID { get => ID_Cli; set => ID_Cli = value; }
        public string alergia { get => ALERGIA; set => ALERGIA = value; }
        public string problema { get => PROBLEMA_DE_SAUDE; set => PROBLEMA_DE_SAUDE = value; }
        public string observacao { get => OBSERVAÇÃO; set => OBSERVAÇÃO = value; }
        public string receita { get => RECEITA; set => RECEITA = value; }
        public DateTime data { get => DATA; set => DATA = value; }

    }
}
