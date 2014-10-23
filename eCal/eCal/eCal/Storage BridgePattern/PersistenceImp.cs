using System;

namespace eCal
{
    internal class PersistenceImp<T> : IPersistence<T>
    {
        private IPersistenceImplementor<T> _implementor;

        public PersistenceImp(IPersistenceImplementor<T> imp)
        {
            _implementor = imp;
        }

        public string Persist(T t)
        {
            throw new NotImplementedException();
        }

        public T FindById(string itemId)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(string id)
        {
            throw new NotImplementedException();
        }
    }
}