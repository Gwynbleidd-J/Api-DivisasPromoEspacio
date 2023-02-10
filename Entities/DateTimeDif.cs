using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public struct DateTimeDif
    {
        public DateTime F_Inicio { get; set; }
        public DateTime F_Fin { get; set; }

        public DateTimeDif(DateTime f_Inicio, DateTime f_Fin)
        {
            F_Inicio= f_Inicio;
            F_Fin= f_Fin;
        }
    }
}
