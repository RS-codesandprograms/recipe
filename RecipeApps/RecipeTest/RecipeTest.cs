using NUnit.Framework.Internal;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionSgring(" \"Server=tcp:dev-codesandprograms.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info = False;User ID=CodesandProgramsAdmin;Password=Hashem Yachol!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}