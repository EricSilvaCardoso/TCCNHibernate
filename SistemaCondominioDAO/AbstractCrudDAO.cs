using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SistemaCondominioDAO.Interfaces;
using System.Linq.Expressions;

namespace SistemaCondominioDAO
{
    public abstract class AbstractCrudDAO<T> : IBaseCrudDAO<T> where T : class 
    {
        private BD_CondominioEntities CondEntidades = new BD_CondominioEntities();

        public void Add(T pEntity)
        {
            CondEntidades.AddObject(pEntity.GetType().Name, pEntity);
        }

        public void Delete(T pEntity)
        {
            CondEntidades.DeleteObject(pEntity);
        }

        public void Altera(T pEntity)
        {
            CondEntidades.ApplyCurrentValues(pEntity.GetType().Name, pEntity);
        }

        public void SaveChanges()
        {
            CondEntidades.SaveChanges();
        }

        public IList<T> Find(Expression<Func<T, bool>> where) 
        {
            return CondEntidades.CreateObjectSet<T>().Where(where).ToList();
        }

        public IList<T> GetAll()
        {
            return CondEntidades.CreateObjectSet<T>().ToList();
        }
    }
}
