using System.Collections.Generic;
using XPWorkshop.DataAccessLayer.DataTransferObjects;

namespace XPWorkshop.DataAccessLayer
{
    /// <summary>
    /// Interface to define the contract for all the data access managers
    /// </summary>
    public interface IDataAccessManager
    {
        /// <summary>
        /// Gets the person information based on the given person identifier
        /// </summary>
        /// <param name="personId">The person identifier</param>
        /// <returns><see cref="PersonDto"/> with the retrieved person information</returns>
        PersonDto SelectById(string personId);

        /// <summary>
        /// Gets the list of persons residing in the given city
        /// </summary>
        /// <param name="cityId">The city identifier</param>
        /// <returns>The list of <see cref="PersonDto"/> with the information of the retrieved persons</returns>
        List<PersonDto> SelectByCityId(long cityId);

        /// <summary>
        /// Retrieves alll the stored persons
        /// </summary>
        /// <returns>A list with the <see cref="PersonDto"/> objects</returns>
        List<PersonDto> SelectAll();
    }
}
