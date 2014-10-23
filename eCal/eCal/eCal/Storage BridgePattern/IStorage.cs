using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCal.Storage
{
    interface IStorage<T>
    {
        /// <summary>
        /// Delete an Item from the Database.
        /// </summary>
        /// <param name="item">The Item to be deleted.</param>
        void Delete(T item);
        
        
        /// <summary>
        /// Update an existing item on the Database.
        /// </summary>
        /// <param name="item">The Item to be updated.</param>
        void Update(T item);
        
        
        /// <summary>
        /// Insert a new Item to the Database.
        /// </summary>
        /// <param name="item">The Item to be Inserted.</param>
        void Insert(T item);


        /// <summary>
        /// Save the changes made to the Database.
        /// </summary>
        void SaveChanges();
    }
}
