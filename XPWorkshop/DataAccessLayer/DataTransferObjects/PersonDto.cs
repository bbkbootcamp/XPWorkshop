namespace XPWorkshop.DataAccessLayer.DataTransferObjects
{
    /// <summary>
    /// Class to store the information regarding a person
    /// </summary>
    public class PersonDto
    {
        /// <summary>
        /// Enumeration to store the genres
        /// </summary>
        public enum GenreType { Male, Female }

        /// <summary>
        /// Gets or sets the person identifier
        /// </summary>
        public string Id { get; set; }

        /// <summary>
        /// Gets or sets the name of a person
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the first name of a person
        /// </summary>
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or sets the last name of a person
        /// </summary>
        public string LastName { get; set; }

        /// <summary>
        /// Gets or sets the age of a person
        /// </summary>
        public int Age { get; set; }

        /// <summary>
        /// Gets or sets the genre or a person
        /// </summary>
        public GenreType Genre { get; set; }

        /// <summary>
        /// Gets or sets the person phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or sets the city identifier where the person is
        /// </summary>
        public long CityId { get; set; }
    }
}
