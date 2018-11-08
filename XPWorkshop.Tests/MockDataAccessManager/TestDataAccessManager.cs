using System.Collections.Generic;
using System.Linq;
using XPWorkshop.DataAccessLayer;
using XPWorkshop.DataAccessLayer.DataTransferObjects;
using static XPWorkshop.DataAccessLayer.DataTransferObjects.PersonDto;

namespace XPWorkshop.Tests.MockDataAccessManager
{
    /// <summary>
    /// Data access manager to be used by the unit tests
    /// </summary>
    internal class TestDataAccessManager : IDataAccessManager
    {
        /// <summary>
        /// The list of persons
        /// </summary>
        private List<PersonDto> personList = new List<PersonDto>
        {
            new PersonDto
            {
                Id = "PER_001",
                Name = "Fernando",
                FirstName = "Ortega",
                LastName = "Agundez",
                Age = 41,
                CityId = 1,
                Genre = GenreType.Male,
                PhoneNumber = "666555444"
            },
            new PersonDto
            {
                Id = "PER_002",
                Name = "Luis",
                FirstName = "López",
                LastName = "Angulo",
                Age = 15,
                CityId = 1,
                Genre = GenreType.Male,
                PhoneNumber = "111222333"
            },
            new PersonDto
            {
                Id = "PER_003",
                Name = "Lorena",
                FirstName = "Gómez",
                LastName = "Pérez",
                Age = 22,
                CityId = 1,
                Genre = GenreType.Female,
                PhoneNumber = "222333444"
            },
            new PersonDto
            {
                Id = "PER_004",
                Name = "Andrea",
                FirstName = "Jiménez",
                LastName = "Jiménez",
                Age = 26,
                CityId = 1,
                Genre = GenreType.Female,
                PhoneNumber = "333444555"
            },
            new PersonDto
            {
                Id = "PER_005",
                Name = "Jose Carlos",
                FirstName = "Ortega",
                LastName = "García",
                Age = 55,
                CityId = 1,
                Genre = GenreType.Male,
                PhoneNumber = "444555666"
            },
            new PersonDto
            {
                Id = "PER_006",
                Name = "Carmen",
                FirstName = "García",
                LastName = "Cuevas",
                Age = 35,
                CityId = 1,
                Genre = GenreType.Female,
                PhoneNumber = "555666777"
            },
            new PersonDto
            {
                Id = "PER_007",
                Name = "Esther",
                FirstName = "Liaño",
                LastName = "Díaz",
                Age = 60,
                CityId = 1,
                Genre = GenreType.Female,
                PhoneNumber = "666777888"
            },
            new PersonDto
            {
                Id = "PER_008",
                Name = "David",
                FirstName = "Martín",
                LastName = "Martín",
                Age = 16,
                CityId = 1,
                Genre = GenreType.Male,
                PhoneNumber = ""
            },
            new PersonDto
            {
                Id = "PER_009",
                Name = "Mario",
                FirstName = "Lopez",
                LastName = "Angulo",
                Age = 24,
                CityId = 1,
                Genre = GenreType.Male,
                PhoneNumber = "777888999"
            },
            new PersonDto
            {
                Id = "PER_010",
                Name = "Lidia",
                FirstName = "Hernández",
                LastName = "Rodríguez",
                Age = 72,
                CityId = 1,
                Genre = GenreType.Female,
                PhoneNumber = "666555444"
            },        
            new PersonDto
            {
                Id = "PER_011",
                Name = "Aitor",
                FirstName = "Díaz",
                LastName = "Muñoz",
                Age = 25,
                CityId = 2,
                Genre = GenreType.Male,
                PhoneNumber = "123234345"
            },
            new PersonDto
            {
                Id = "PER_012",
                Name = "Luis Alberto",
                FirstName = "Mendiguren",
                LastName = "Angulo",
                Age = 8,
                CityId = 2,
                Genre = GenreType.Male,
                PhoneNumber = "234456567"
            },
            new PersonDto
            {
                Id = "PER_013",
                Name = "Aitana",
                FirstName = "Gómez",
                LastName = "Pérez",
                Age = 32,
                CityId = 2,
                Genre = GenreType.Female,
                PhoneNumber = "655897412"
            },
            new PersonDto
            {
                Id = "PER_014",
                Name = "Andrea",
                FirstName = "Lopez",
                LastName = "Jiménez",
                Age = 4,
                CityId = 2,
                Genre = GenreType.Female,
                PhoneNumber = ""
            },
            new PersonDto
            {
                Id = "PER_015",
                Name = "Imanol",
                FirstName = "Ortega",
                LastName = "Díaz",
                Age = 72,
                CityId = 2,
                Genre = GenreType.Male,
                PhoneNumber = ""
            },
            new PersonDto
            {
                Id = "PER_016",
                Name = "Begoña",
                FirstName = "Ballesteros",
                LastName = "Cuevas",
                Age = 18,
                CityId = 3,
                Genre = GenreType.Female,
                PhoneNumber = "356279642"
            },
            new PersonDto
            {
                Id = "PER_017",
                Name = "Aitaña",
                FirstName = "Liaño",
                LastName = "Díaz",
                Age = 45,
                CityId = 3,
                Genre = GenreType.Female,
                PhoneNumber = "652142368"
            },
            new PersonDto
            {
                Id = "PER_018",
                Name = "Judit",
                FirstName = "Martín",
                LastName = "Fajardo",
                Age = 17,
                CityId = 3,
                Genre = GenreType.Female,
                PhoneNumber = "666258693"
            },
            new PersonDto
            {
                Id = "PER_019",
                Name = "Luisa",
                FirstName = "Lopez",
                LastName = "Angulo",
                Age = 26,
                CityId = 3,
                Genre = GenreType.Female,
                PhoneNumber = "633555444"
            },
            new PersonDto
            {
                Id = "PER_020",
                Name = "Lorena",
                FirstName = "Díaz",
                LastName = "Rodríguez",
                Age = 51,
                CityId = 3,
                Genre = GenreType.Female,
                PhoneNumber = "661335224"
            }
        };

        #region IDataAccessManager implementation

        /// <summary>
        /// Returns the persons stored in both lists
        /// </summary>
        /// <returns></returns>
        public List<PersonDto> SelectAll()
        {
            return personList;
        }

        /// <summary>
        /// Returns the persons based on the recevied city identifier
        /// </summary>
        /// <param name="cityId">The city identifier</param>
        /// <returns>The list of persons living in the given city</returns>
        public List<PersonDto> SelectByCityId(long cityId)
        {
            return personList.Where(p => p.CityId == cityId).Cast<PersonDto>().ToList();
        }

        /// <summary>
        /// Selects a persons based on received identifier
        /// </summary>
        /// <param name="personId">The person identifier</param>
        /// <returns>The <see cref="PersonDto"/> with the person information</returns>
        public PersonDto SelectById(string personId)
        {
            return personList.FirstOrDefault(p => p.Id == personId);
        }

        #endregion
    }
}
