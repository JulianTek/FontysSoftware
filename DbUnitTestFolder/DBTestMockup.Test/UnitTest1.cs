using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DBTestMockup.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getTest()
        {
            Data.EmpDto empDto = new Data.EmpDto("Jan Janssen");
            Data.EmpDto expected = empDto;
            int id = 8;

            Data.DatabaseManager databaseManager = new Data.DatabaseManager();
            var actual = databaseManager.getEmployee(id);
            Assert.AreEqual(expected, actual);
        }
    }
}
