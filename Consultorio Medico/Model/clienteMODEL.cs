using Consultorio_Medico.DAO;
using Consultorio_Medico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consultorio_Medico.Model
{
    class clienteMODEL
    {
        internal static int Inserir(clienteENT objtabela)
        {
            return new clienteDAO().Inserir(objtabela);
        }

        internal List<clienteENT> Lista()
        {
            return new clienteDAO().Lista();
        }

        internal static int Alterar(clienteENT objtabela)
        {
            return new clienteDAO().Alterar(objtabela);
        }

        internal static int Deletar(clienteENT objtabela)
        {
            return new clienteDAO().Deletar(objtabela);
        }
    }
}
