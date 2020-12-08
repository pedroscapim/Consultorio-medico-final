using Consultorio_Medico.DAO;
using Consultorio_Medico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Consultorio_Medico.Model
{
    class medicoMODEL
    {
        internal static int Inserir(medicoENT objtabela)
        {
            return new medicoDAO().Inserir(objtabela);
        }

        internal static int Alterar(medicoENT objtabela)
        {
            return new medicoDAO().Alterar(objtabela);
        }

        internal List<medicoENT> Lista()
        {
            return new medicoDAO().Lista();
        }

        internal static int Deletar(medicoENT objtabela)
        {
            return new medicoDAO().Deletar(objtabela);
        }
    }
}
