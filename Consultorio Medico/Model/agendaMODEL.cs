using Consultorio_Medico.DAO;
using Consultorio_Medico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_Medico.Model
{
    class agendaMODEL
    {
        internal static int Inserir(agendaENT objtabela)
        {
            return new agendaDAO().Inserir(objtabela);
        }

        internal static int Alterar(agendaENT objtabela)
        {
            return new agendaDAO().Alterar(objtabela);
        }

        internal List<agendaENT> Lista()
        {
            return new agendaDAO().Lista();
        }

        internal static int Deletar(agendaENT objtabela)
        {
            return new agendaDAO().Deletar(objtabela);
        }
    }
}
