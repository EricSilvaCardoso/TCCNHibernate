using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace SistemaCondominioDAO.Interfaces
{
    public interface IBaseCrudDAO<T>
    {
        void Add(T pEntity);
        void Delete(T pEntity);
        void Altera(T pEntity);
        IList<T> Find(Expression<Func<T, bool>> where);
        IList<T> GetAll();
        void SaveChanges();
    }
}
