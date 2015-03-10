using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace SistemaCondominioNHDAO
{
    public interface IBaseCrudNHDAO<T>
    {
        void Inserir(T entidade);
        void Alterar(T entidade);
        void Excluir(T entidade);
        T RetornarPorId(int id);
        IList<T> Find(Expression<Func<T, bool>> where);
        IList<T> GetAll();
    }
}
