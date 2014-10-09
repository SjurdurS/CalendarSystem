using System;

namespace CalendarApplication
{
    public class FileStorage<T> : IPersistenceImplementor<T>
    {
        public long SaveObject(T t)
        {
            throw new NotImplementedException();
        }

        public void DeleteObject(long objectId)
        {
            throw new NotImplementedException();
        }

        public T GetObject(long objectId)
        {
            throw new NotImplementedException();
        }

        private T ReadObjectFromFile(T t)
        {
            throw new NotImplementedException();
        }

        private void WriteObjectToFile(T t)
        {
            throw new NotImplementedException();
        }
    }
}