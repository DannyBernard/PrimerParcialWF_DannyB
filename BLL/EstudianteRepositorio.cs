using Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class EstudianteRepositorio : RepositorioBase<Estudiante>
    {
        public override Estudiante Buscar(int id)
        {
            Estudiante e = new Estudiante();
            try
            {
                e = _contexto.estudiantes.Find(id);
                e.Detalle.Count();

            }
            catch (Exception)
            {
                throw;
            }
            return e;
        }

        public override bool Modificar(Estudiante entity)
        {
            bool paso = false;
            try
            {
                foreach (var item in entity.Detalle)
                {
                    var estado = item.EstudianteID > 0 ? EntityState.Modified : EntityState.Added;
                    _contexto.Entry(item).State = estado;
                }

                _contexto.Entry(entity).State = EntityState.Modified;

                if (_contexto.SaveChanges() > 0)
                    paso = true;
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }
    }
}

