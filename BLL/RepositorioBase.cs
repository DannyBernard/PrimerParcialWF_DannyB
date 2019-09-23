using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class RepositorioBase<T> : IDisposable, IRepository<T> where T : class
    {
        
        internal Contexto _contexto;

        public RepositorioBase()
        {
            _contexto = new Contexto();
        }
       
        public T Buscar(int id)
        {
            T entity;
            try
            {
                entity = _contexto.
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> GetList(Expression<Func<T, bool>> expression)
        {
            throw new NotImplementedException();
        }

        public bool Guardar(T entity)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
