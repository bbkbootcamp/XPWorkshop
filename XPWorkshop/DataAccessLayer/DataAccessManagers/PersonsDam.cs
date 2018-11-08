using System;
using System.Collections.Generic;
using XPWorkshop.DataAccessLayer.DataTransferObjects;

namespace XPWorkshop.DataAccessLayer.DataAccessManagers
{
    /// <summary>
    /// Data access manager to retrieve all the information of the persons
    /// </summary>
    public class DatabasePersonDAM : IDataAccessManager
    {
        #region IDataAccessManager implementation

        /// <summary>
        /// Method to access the database retrieving the person information
        /// </summary>
        /// <param name="personId"></param>
        /// <returns><see cref="PersonDto"/> with the retrieved person information</returns>
        public PersonDto SelectById(string personId)
        {
            throw new NotImplementedException("There is no configured database");
        }

        /// <summary>
        /// Gets the list of persons residing in the given city
        /// </summary>
        /// <param name="cityId">The city identifier</param>
        /// <returns>The list of <see cref="PersonDto"/> with the information of the retrieved persons</returns>
        public List<PersonDto> SelectByCityId(long cityId)
        {
            throw new NotImplementedException("There is no configured database");
        }

        /// <summary>
        /// Selects all the persons stored in the database
        /// </summary>
        /// <returns>List of <see cref="PersonDto"/> with the retrieved information</returns>
        public List<PersonDto> SelectAll()
        {
            throw new NotImplementedException("There is no configured database");
        }

        #endregion
    }
}
