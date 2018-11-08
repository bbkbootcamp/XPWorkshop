using Microsoft.VisualStudio.TestTools.UnitTesting;
using XPWorkshop.Tests.MockDataAccessManager;

namespace XPWorkshop.Tests
{
    /// <summary>
    /// Test class to ensure the Business class works as expected
    /// </summary>
    [TestClass()]
    public class BusinessClassTests
    {
        #region Private Members

        /// <summary>
        /// The business facade object to be tested
        /// </summary>
        private BusinessClass myBf;

        #endregion

        /// <summary>
        /// Configures the common objects to be used during the tests
        /// </summary>
        [TestInitialize]
        public void TestSetup()
        {
            myBf = new BusinessClass(new TestDataAccessManager());
        }

        /// <summary>
        /// Test to ensure the GetPersonCompleteName works properly
        /// </summary>
        [TestMethod]
        public void GetPersonCompleteNameTest()
        {
            
        }

        /// <summary>
        /// Test to ensure the method GetPeopleWithVotingRights works as expected
        /// </summary>
        [TestMethod]
        public void GetPeopleWithVotingRightsTest()
        {
        }
    }
}