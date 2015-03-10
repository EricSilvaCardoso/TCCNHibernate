using NHibernate;
using NHibernate.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Linq.Expressions;

namespace SistemaCondominioNHDAO
{
    public class AbstractCrudNHDAO<T> : IBaseCrudNHDAO<T> where T : class
    {
        public void Inserir(T entidade)
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Save(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Inserir entidade : " + ex.Message);
                    }
                }
            }
        }

        public void Alterar(T entidade)
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Update(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Atualizar entidade : " + ex.Message);
                    }
                }
            }
        }

        public void Excluir(T entidade)
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                using (ITransaction transacao = session.BeginTransaction())
                {
                    try
                    {
                        session.Delete(entidade);
                        transacao.Commit();
                    }
                    catch (Exception ex)
                    {
                        if (!transacao.WasCommitted)
                        {
                            transacao.Rollback();
                        }
                        throw new Exception("Erro ao Excluir entidade : " + ex.Message);
                    }
                }
            }
        }

        public T RetornarPorId(int id)
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                return session.Get<T>(id);
            }
        }

        public IList<T> Find(Expression<Func<T, bool>> where)
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                return session.Query<T>().Where<T>(where).ToList();
            }
        }

        public IList<T> GetAll()
        {
            using (ISession session = FluentSessionFactory.AbrirSession())
            {
                return session.Query<T>().ToList();
            }
        }    
    }
}
