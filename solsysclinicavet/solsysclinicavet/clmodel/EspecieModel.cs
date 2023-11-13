using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clmodel
{
    public class EspecieModel
    {
        private int _Codigo;
        private string _Nome;

        public int Codigo { get { return _Codigo; } set { _Codigo = value; } }
        public string Nome { get { return _Nome; } set { _Nome = value; } }
    }
}
