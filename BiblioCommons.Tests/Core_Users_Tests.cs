using System.Linq;
using BiblioCommons.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiblioCommons.Tests
{
    [TestClass]
    public class Core_Users_Tests
    {
        [TestMethod]
        public void SearchUsers_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "SearchUsersSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.SearchUsers("Jeremy");

                // Assert
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.users);
                Assert.AreEqual("68505399", result.users.First().id);
            }
        }


        [TestMethod]
        public void GetUser_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetUserSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetUser("68505399");

                // Assert
                Assert.IsNotNull(result);
                Assert.AreEqual("68505399", result.id);
            }
        }


        [TestMethod]
        public void GetUserLists_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetUserListsSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetUserLists("88095249");

                // Assert
                Assert.IsNotNull(result);
                Assert.IsNotNull(result.lists);
                Assert.AreEqual(10, result.lists.Count);
                Assert.AreEqual("94279262", result.lists.First().id);
            }
        }


        [TestMethod]
        public void GetUserContent_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetUserListsSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetUserContent("88095249");

                // Assert
                Assert.IsNotNull(result);
                //Assert.IsNotNull(result.user);
                //Assert.IsNotNull(result.content);
            }
        }
    }
}
