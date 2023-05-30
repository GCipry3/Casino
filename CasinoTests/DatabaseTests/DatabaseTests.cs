using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Database;
using System.Data;
using Users;

namespace CasinoTests.DatabaseTests
{
    [TestClass]
    public class DatabaseTests
    {
        SQliteDatabase sqliteDatabase;
        SQLiteUserDatabase userDatabase;

        [TestInitialize]
        public void Initialize()
        {
            sqliteDatabase = new SQliteDatabase();
            userDatabase = new SQLiteUserDatabase(sqliteDatabase);
        }

        [TestMethod]
        public void TestDBConnection()
        {
            // Expecting the connection to be open
            Assert.AreEqual(System.Data.ConnectionState.Open, sqliteDatabase.GetDBConnection().State);
        }

        [TestMethod]
        public void TestExecuteQueryWithResult()
        {
            // This query is expected to return at least one user
            var reader = sqliteDatabase.ExecuteUserQueryWithResult("SELECT * FROM Users");

            // Expecting to have at least one row
            Assert.IsTrue(reader.HasRows);
        }

        [TestMethod]
        public void TestExecuteQuery()
        {
            // This query is expected not to throw any exceptions
            sqliteDatabase.ExecuteUserQuery("SELECT * FROM Users");

            // If the test reaches this point, then the query execution is successful, and we pass the test
            Assert.IsTrue(true);
        }

        [TestMethod]
        public void TestCreateExtractAndDeleteUser()
        {
            userDatabase.CreateUser("TestUser", "TestPassword", "Admin");
            
            IUser user = userDatabase.GetUser("TestUser");
            Assert.IsNotNull(user);
            Assert.AreEqual("TestUser", user.Username);
            Assert.AreEqual("TestPassword", user.Password);
            Assert.AreEqual("Admin", user.Role);
            Assert.AreEqual(0, user.Balance);

            userDatabase.DeleteUser("TestUser");
            user = userDatabase.GetUser("TestUser");
            Assert.IsNull(user);
        }

        [TestMethod]
        public void TestAddMoney()
        {
            userDatabase.CreateUser("TestUser", "TestPassword", "Admin");
            Assert.AreEqual(0, userDatabase.GetUserBalance("TestUser"));

            userDatabase.AddUserBalance("TestUser", 100);
            Assert.AreEqual(100, userDatabase.GetUserBalance("TestUser"));
            userDatabase.AddUserBalance("TestUser", 200);
            Assert.AreEqual(300, userDatabase.GetUserBalance("TestUser"));
            userDatabase.AddUserBalance("TestUser", -100);
            Assert.AreEqual(200, userDatabase.GetUserBalance("TestUser"));

            userDatabase.DeleteUser("TestUser");
            Assert.IsNull(userDatabase.GetUser("TestUser"));
        }

        /*[TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestGetMoneyFromNonExistingUser()
        {
            userDatabase.CreateUser("TestUser", "TestPassword", "Admin");

            Assert.IsNotNull(userDatabase.GetUser("TestUser"));

            userDatabase.DeleteUser("TestUser");
            Assert.IsNull(userDatabase.GetUser("TestUser"));

            userDatabase.GetUserBalance("TestUser");
        }*/
    }
}
