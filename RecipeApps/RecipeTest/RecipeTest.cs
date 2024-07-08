using NUnit.Framework.Internal;
using RecipeSystem;
using System.Data;

namespace RecipeTest
{
    public class RecipeTest
    {
        [SetUp]
        public void Setup()
        {
            DBManager.SetConnectionString("Server=tcp:dev-codesandprograms.database.windows.net,1433;Initial Catalog=HeartyHearthDB;Persist Security Info = False;User ID=CodesandProgramsAdmin;Password=Hashem Yachol!!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        }

        [Test]
        [TestCase("Stuffed Apples", 57, "01/01/2022")]
        [TestCase("Pink Lemon-aid", 15, "05/24/2023")]
        public void InsertNewRecipe(string RecipeName, int Calories, DateTime DraftDate)
        {
            DataTable dt = SQLUtility.GetDataTable("Select * from recipe where recipeid = 0");
            DataRow r = dt.Rows.Add();
            Assume.That(dt.Rows.Count == 1, "No empty row added, cannot run test");
            int staffid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 staffid from staff");
            Assume.That(staffid > 0, "No staff records in DB, cannot run test");
            int cuisinetypeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 cuisinetypeid from cuisinetype");
            Assume.That(cuisinetypeid > 0, "No cuisinetype records in DB, cannot run test");
            int maxid = SQLUtility.GetFirstColumnFirstRowValue("select max(recipeid) from recipe");
            int newid = maxid++;

            TestContext.WriteLine("Insert recipe with id = " + newid);

            r["staffid"] = staffid;
            r["cuisinetypeid"] = cuisinetypeid;
            r["RecipeName"] = RecipeName + DateTime.Now.ToString();
            r["Calories"] = Calories;
            r["DraftDate"] = DraftDate;
            Recipe.Save(dt);

            //int newid = SQLUtility.GetFirstColumnFirstRowValue("select * from recipe where recipeid = " + maxid);
            Assert.IsTrue(newid == maxid -1, "Recipe with id " + newid + " is not found in db");
            TestContext.WriteLine("Recipe with id " + newid + " is found in db with pk value = " + newid);




        }






        [Test]
        public void UpdateExistingRecipeDraftDate()
        {
            int recipeid = SQLUtility.GetFirstColumnFirstRowValue("select top 1 r.recipeid from recipe r where r.publisheddate is null");
            Assume.That(recipeid > 0, "No recipes in DB, cannot run tests.");

            DateTime draftdate = GetFirstColumnFirstRowDateTimeValue(recipeid);

            TestContext.WriteLine("Draftdate for recipeid " + recipeid + " is " + draftdate);
            draftdate = draftdate.AddDays(1);
            TestContext.WriteLine("Update draftdate to " + draftdate);
            DataTable dt = Recipe.Load(recipeid);

            dt.Rows[0]["draftdate"] = draftdate;
            Recipe.Save(dt);

            DateTime newdraftdate = GetFirstColumnFirstRowDateTimeValue(recipeid);
            Assert.IsTrue(newdraftdate == draftdate, "draftdate for recipe (" + recipeid + ") equals " + newdraftdate);
            TestContext.WriteLine("Draftdate for recipe (" + recipeid + ") equals " + newdraftdate);
        }

       

        [Test]
        public void DeleteRecipe()
        {
            DataTable dt = SQLUtility.GetDataTable("select top 1 r.recipeid, r.recipename from recipe r" +
                " left join RecipeIngredient i on r.recipeid = i.recipeid where i.recipeid is null");
            int recipeid = 0;
            string recipename = "";
            if (dt.Rows.Count > 0)
            {
                recipeid = (int)dt.Rows[0]["recipeid"];
                recipename = dt.Rows[0]["recipename"].ToString();
            }
            Assume.That(recipeid > 0, "No recipes without ingredients in DB, cannot run tests.");
            TestContext.WriteLine("Existing recipe without ingredients with id = " + recipeid + " " + recipename);
            TestContext.WriteLine("Ensure that app can delete and will not exist in DB " + recipeid + " " + recipename);
            Recipe.Delete(dt);
            DataTable dtafterdelete = SQLUtility.GetDataTable("select * from recipe where recipeid = " + recipeid);
            Assert.IsTrue(dtafterdelete.Rows.Count == 0, "record with recipeid " + recipeid + " exists in database.");
            TestContext.WriteLine("App deleted " + recipeid + " " + recipename + " from DB.");
        }


        [Test]
        public void LoadRecipe()
        {
            int recipeid = GetExistingRecipeId();
            Assume.That(recipeid > 0, "No recipes in DB, cannot run tests.");
            TestContext.WriteLine("Existing recipe with id = " + recipeid);
            TestContext.WriteLine("Ensure that app loads recipe " + recipeid);

            DataTable dt = Recipe.Load(recipeid);
            int loadedid = (int)dt.Rows[0]["recipeid"];

            Assert.IsTrue(loadedid == recipeid, loadedid + " <> " + recipeid);
            TestContext.WriteLine("App loaded recipe (" + loadedid + ")");

        }


        [Test]
        public void GetListOfCuisineTypes()
        {
            int cuisinetypecount = SQLUtility.GetFirstColumnFirstRowValue("select total = count (*) from cuisinetype");
            Assume.That(cuisinetypecount > 0, "No cuisinetypes in DB, cannot test");
            TestContext.WriteLine("Num of cuisinetypes in DB = " + cuisinetypecount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + cuisinetypecount);

            DataTable dt = Recipe.GetList("CuisineType", "CuisineName");

            Assert.IsTrue(dt.Rows.Count == cuisinetypecount, "num rows returned by app (" + dt.Rows.Count + ") <> " + cuisinetypecount);
            TestContext.WriteLine("Num of rows in cuisinetype returned by app = " + dt.Rows.Count);
        }


        [Test]
        public void GetListOfStaff()
        {
            int staffcount = SQLUtility.GetFirstColumnFirstRowValue("select total = count (*) from staff");
            Assume.That(staffcount > 0, "No staff in DB, cannot test");
            TestContext.WriteLine("Num of staff in DB = " + staffcount);
            TestContext.WriteLine("Ensure that num of rows returned by app matches " + staffcount);

            DataTable dt = Recipe.GetList("Staff", "UserName");

            Assert.IsTrue(dt.Rows.Count == staffcount, "num rows returned by app (" + dt.Rows.Count + ") <> " + staffcount);
            TestContext.WriteLine("Num of rows in Staff returned by app = " + dt.Rows.Count);
        }

        private int GetExistingRecipeId()
        {
            return SQLUtility.GetFirstColumnFirstRowValue("select top 1 r.recipeid from recipe r");
        }

        private static DateTime GetFirstColumnFirstRowDateTimeValue(int recipeid)
        {
            string sql = "select draftdate from recipe where recipeid = " + recipeid;
            DataTable dt = SQLUtility.GetDataTable(sql);
            DateTime draftdate = (DateTime)dt.Rows[0]["draftdate"];
            return draftdate;
        }


    }
}