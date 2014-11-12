using System;

namespace eCal.SyncSubsystem
{
    /// <summary>
    ///     Source http://www.oodesign.com/bridge-pattern-object-persistence-api-example-java-sourcecode.html
    /// </summary>
    public interface IPersistence
    {
        /// <summary>
        /// </summary>
        /// <param name="t">Item</param>
        /// <returns>The id of the Item</returns>
        string Persist(Object obj);

        /// <summary>
        /// </summary>
        /// <param name="itemId"></param>
        /// <returns></returns>
        Object FindById(String itemId);

        /// <summary>
        /// </summary>
        /// <param name="id"></param>
        void DeleteById(String id);
    }
}