using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpInvestigacion.Data.Entidades;

namespace TpInvestigacion.Servicio.Interfaces
{
    public interface IServicio
    {
        void AgregarBloque(string dato);
        List<Bloque> ListarBloques();
        Bloque BuscarBloquePorId(int Id);
        void ModificarBloque(Bloque bloqueEditado);
        void EliminarBloque(int Id);
        string VerificarIntegridad();
    }
}
