using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TpInvestigacion.Data.Entidades;

namespace TpInvestigacion.Data.Interfaces
{
    public interface IRepositorio
    {
        void GuardarBloque(Bloque bloque);
        List<Bloque> GetCadena();
        Bloque BuscarBloquePorId(int id);
        void ModificarBloque(Bloque bloqueEditado);
        void EliminarBloque(int Id);
        Bloque UltimoBloque();
        int ContadorBloques();
    }
}
