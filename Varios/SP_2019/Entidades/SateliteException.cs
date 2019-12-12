using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entidades
{
    public class SateliteException : Exception
    {
        public SateliteException() : base ("No se puede crear el satélite")
        {
        }
    }
}
