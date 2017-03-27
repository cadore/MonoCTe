using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonoCT_e.enums
{
    public class Enum
    {
        public enum TypeVehicle
        {
            TRACAO = 0,
            REBOQUE = 1
        }

        public enum TypeWeedled
        {
            NAO_APLICAVEL = 00,
            TRUCK = 01,
            TOCO = 02,
            CAVALO_MECANICO = 03,
            VAN = 04,
            UTILITARIO = 05,
            OUTROS = 06
        }
        public enum TypeBody
        {
            NAO_APLICAVEL = 00,
            ABERTA = 01,
            FECHADA_BAU = 02,
            GRANELEIRA = 03,
            PORTA_CONTAINER = 04,
            SIDER = 05
        }
    }
}
