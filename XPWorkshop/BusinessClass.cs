using System;
using System.Collections.Generic;
using XPWorkshop.DataAccessLayer;
using XPWorkshop.DataAccessLayer.DataTransferObjects;

namespace XPWorkshop
{
    /// <summary>
    /// The class where the business is
    /// </summary>
    public class BusinessClass
    {
        #region Private Members

        /// <summary>
        /// Data access manager to be used to retrieve the data
        /// </summary>
        private readonly IDataAccessManager myDam;

        #endregion

        #region Lifetime

        /// <summary>
        /// Initializes a new instance of a <see cref="BusinessClass"/> object
        /// </summary>
        /// <param name="dam">The <see cref="IDataAccessManager"/> to be used</param>
        public BusinessClass(IDataAccessManager dam)
        {
            myDam = dam;
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Gets the complete name of a given person
        /// </summary>
        /// <param name="personId">Person identifier to retrieve the name</param>
        /// <returns>The name + first and last names</returns>
        public string GetPersonCompleteName(string personId)
        {
            var dbPerson = myDam.SelectById(personId);

            return string.Format("{0} {1} {2}", dbPerson.Name, dbPerson.FirstName, dbPerson.LastName);
        }

        /// <summary>
        /// Gets the list of persons having voting rights in a given city
        /// </summary>
        /// <param name="cityId">The city identifier</param>
        /// <param name="age">The age which determines whether the person has voting rights or not</param>
        /// <returns>The list of <see cref="PersonDto"/> with the person information</returns>
        public List<PersonDto> GetPeopleWithVotingRights(string cityId, int age)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
