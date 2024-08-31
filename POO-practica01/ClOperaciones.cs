using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_practica01
{
    internal class ClOperaciones
    {
        //Cómo es (caracteristicas, campos)
        private decimal val1;
        private decimal val2;

        //Propiedades get, set
        public decimal Val1 { get => val1; set => val1 = value; }
        public decimal Val2 { get => val2; set => val2 = value; }

        //Constructores
        public ClOperaciones(decimal val1, decimal val2)
        {
            this.val1 = val1;
            this.val2 = val2;
        }

        public ClOperaciones()
        {

        }

        //Lo que hace (acción)
        public decimal suma()
        {
            return ( val1 + val2 );
        }

        public decimal resta()
        {
            return ( val1 - val2 );
        }
        public decimal division()
        {
            return (val1 / val2);
        }
        public decimal multi()
        {
            return (val1 * val2);
        }

    }
}
