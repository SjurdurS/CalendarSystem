using System;

namespace CalendarApplication
{
    /// <summary>
    /// Source http://www.oodesign.com/bridge-pattern-object-persistence-api-example-java-sourcecode.html
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IPersistence<T>
    {
        /// <summary>
        /// </summary>
        /// <param name="t">Item</param>
        /// <returns>The id of the Item</returns>
        string Persist(T t);

        /// <summary>
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        T FindById(String itemId);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        void DeleteById(String id);
    }
}