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
            _contexto.Add(bloque);
            _contexto.SaveChanges();
        }

        public List<Bloque> GetCadena()
        {
            List<Bloque> lista = _contexto.Bloques.ToList();
            if (lista != null)
            {
                return lista;
            }
            else
            {
                throw new ArgumentException("Lista vacia");
            }
            
        }

        public Bloque UltimoBloque()
        {
            Bloque bloque = _contexto.Bloques.Last();
            if( bloque != null)
            {
                return bloque;
            }
            else
            {
                throw new ArgumentException("El argumento no es válido");
            }
            
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
