using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ESA.Common;
using NHibernate;
using NHibernate.Criterion;
using NHibernate.Linq;

namespace ESA.DAL.Almaty.Repositories {
    public abstract class Repository : IDisposable {
        protected internal ISession Session;
        public virtual void Dispose() {
            if (Session == null) {
                return;
            }
            TransactionRollBack();
            //TransactionCommit();
        }
        protected void TransactionCommit() {
            if (Session.Transaction != null && Session.Transaction.IsActive) {
                if (!Session.Transaction.WasCommitted && !Session.Transaction.WasRolledBack) {
                    Session.Transaction.Commit();
                    Session.Transaction.Begin();
                }
                //Session.Transaction.Dispose();
            }
        }

        protected void TransactionRollBack()
        {
            if (Session.Transaction != null && Session.Transaction.IsActive)
            {
                if (!Session.Transaction.WasCommitted && !Session.Transaction.WasRolledBack)
                {
                    Session.Transaction.Rollback();
                    Session.Transaction.Begin();
                }
                Session.Transaction.Dispose();
            }
        }
        public bool Commit() {
            try {
                TransactionCommit();
            }
            catch (Exception ex) {
                NHibLogger.Error("Repository.Commit", ex);
                throw;
            }
            return true;
        }
        protected void OpenTransactionIfNotOpened() {
            if (Session.Transaction == null || !Session.Transaction.IsActive) {
                Session.BeginTransaction();
            }
        }
        public ISession GetCurrentSession { get { return this.Session; } }
    }

    public class Repository<T> : Repository where T : class ,IEntity {
        public Repository() {
            Session = Provider.GetCurrentSession() ?? Provider.OpenDbSession();
            Session.FlushMode = FlushMode.Always;
        }

        public Repository(Repository repository) {
            Session = repository.Session;
        }


        public virtual IQueryable<T> Get() {
            return Session.Query<T>();
        }

        public virtual IQueryable<T> Get(Expression<Func<T, bool>> predicate) {
            return Get().Where(predicate);
        }

        public virtual T Get(long id) {
            return Session.Get<T>(id);
        }

        public virtual TT Load<TT>(long id) {
            return Session.Load<TT>(id);
        }

        public virtual void Insert(T entity) {
            OpenTransactionIfNotOpened();
            Session.Save(entity);
        }

        public virtual void Insert(IEnumerable<T> entities) {
            OpenTransactionIfNotOpened();
            foreach (var entity in entities) {
                Session.Save(entity);
            }
        }

        public virtual void Update(T entity) {
            OpenTransactionIfNotOpened();
            Session.Update(entity);
        }

        public virtual void InsertOrUpdate(IEnumerable<T> entities) {
            OpenTransactionIfNotOpened();
            foreach (var entity in entities) {
                Session.SaveOrUpdate(entity);
            }
        }

        public virtual void InsertOrUpdate(T entity) {
            OpenTransactionIfNotOpened();
            Session.SaveOrUpdate(entity);
        }

        public virtual void Delete(T entity) {
            OpenTransactionIfNotOpened();
            Session.Delete(entity);
        }

        public virtual void Delete(long id) {
            OpenTransactionIfNotOpened();
            Session.Delete(Session.Load<T>(id));
        }

        public virtual bool Any(Expression<Func<T, bool>> predicate = null)
        {
            if (predicate == null)
            {
                return Session.Query<T>().Any();
            }
            return Session.Query<T>().Any(predicate);
        }
        public virtual int Count() {
            var count = Session.CreateCriteria<T>().SetProjection(Projections.RowCount()).UniqueResult<int>();
            return count;
        }

        public virtual int Count(Expression<Func<T, bool>> predicate)
        {
            return Session.QueryOver<T>().Where(predicate).RowCount();
        }


        public virtual void StorageProc(string nameOfProcedure,string[] parameters)
        {
            using (var sesstion = new Repository<T>().Session)
            {
                sesstion.GetNamedQuery(nameOfProcedure);
            }
        }

        //TODO думаю над реализацией пейджинга... (если уже не забыл)
        public virtual IQueryable<T> Page(ref int number, int size, out int count, Expression<Func<T, bool>> expression = null, bool orderByAsc = true) {
            
            var rowCount = expression != null ? Count(expression) : Count();

            count = rowCount / size;

            if (rowCount%size > 0) {
                count++;                
            }

            if (number < 1) {
                number = 1;                
            }

            if (number > count) {
                number = count;
            }

            var query = expression != null?  Get(expression): Get();
            query = orderByAsc ? query.OrderBy(x => x.Id) : query.OrderByDescending(x => x.Id);
            return query.Skip((number - 1) * size).Take(size);
        }
    }
}
