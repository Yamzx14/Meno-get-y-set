using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meno_get_y_set
{
    internal class menoclass
    {
        
        private int N1;
        private int N2;

        public int N11 { get => N1; set => N1 = value; }
        public int N21 { get => N2; set => N2 = value; }

        //metodo, accion, lo que hace.
        public int meno()
        {
            return (N1 - N2);
        }
    }
}
