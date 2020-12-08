using Consultorio_Medico.DAO;
using Consultorio_Medico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_Medico.Model
{
    class sintomaMODEL
    {
        internal static int Salvar(sintomaENT objtabela)
        {
            return new sintomaDAO().Salvar(objtabela);
        }

        internal List<sintomaENT> Lista()
        {
            return new sintomaDAO().Lista();
        }
    }
}
