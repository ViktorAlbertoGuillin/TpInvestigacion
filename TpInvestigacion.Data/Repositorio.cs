using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TpInvestigacion.Data.Entidades;
using TpInvestigacion.Data.Interfaces;


namespace TpInvestigacion.Data
{
    public class Repositorio : IRepositorio
    {
        private TpInvestigacionContext _contexto;
        public Repositorio(TpInvestigacionContext contexto)
        {
            _contexto = contexto;
        }

        public void GuardarBloque(Bloque bloque)
        {
            _contexto.Bloques.Add(bloque);
            _contexto.SaveChanges();
        }

        public List<Bloque> GetCadena()
        {
            return _contexto.Bloques.ToList();
        }

        public Bloque UltimoBloque()
        {
            return _contexto.Bloques.Last();
        }

        public int ContadorBloques()
        {
            return _contexto.Bloques.Count();
        }

        public Bloque BuscarBloquePorId(int id)
        {
            return _contexto.Bloques.Find(id);
        }

        public void ModificarBloque(Bloque bloqueEditado)
        {
            Bloque bloque = _contexto.Bloques.Find(bloqueEditado.Id);
            bloque.Datos = bloqueEditado.Datos;
            bloque.Hash = bloqueEditado.Hash;
            bloque.HashAnterior = bloqueEditado.HashAnterior;
            bloque.Tiempo = bloqueEditado.Tiempo;
            _contexto.SaveChanges();
        }

        public void EliminarBloque(int Id)
        {
            Bloque bloque = _contexto.Bloques.Find(Id);
            _contexto.Bloques.Remove(bloque);
            _contexto.SaveChanges();
        }
    }
}
