using System.Net;
using BiblioCommons.Exceptions;
using BiblioCommons.Tests.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BiblioCommons.Tests
{
    [TestClass]
    public class Core_Lists_Tests
    {
        [TestMethod]
        public void GetLists_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetListsSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetLists();

                // Assert
                Assert.IsTrue(result != null);
                Assert.AreEqual(10, result.lists.Count);
            }
        }


        [TestMethod]
        public void GetList_SuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetListSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient();

                // Act
                var result = client.GetList("96053493");

                // Assert
                Assert.IsTrue(result != null);
                Assert.AreEqual("96053493", result.id);
                Assert.AreEqual(32, result.list_items.Count);
            }
        }
    }
}
