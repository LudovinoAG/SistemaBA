using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_Gestión.Modelos
{
    public interface IFormularios
    {
        void NuevaFecha(string fecha);
        void CantidadViaje(int cantidad);

        void DetallesViajesChofer(string PRODUCTO,int CANTIDAD, string NUMFACT, int CONDUCE, string CHOFER);
    }
}
