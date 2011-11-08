using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using BiblioCommons.Tests.Helpers;

namespace BiblioCommons.Tests
{
    [TestClass]
    public class Core_Libraries_Tests
    {
        [TestMethod]
        public void GetLibrary_JsonLibrarySuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetLibrarySuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetLibrary();

                // Assert
                Assert.IsTrue(result != null);
                Assert.AreEqual(result.id, "euclidlibrary");
                Assert.AreEqual(result.name, "Euclid Public Library");
                Assert.AreEqual(result.catalog_url, "http://euclidlibrary.bibliocommons.com");
            }
        }

        [TestMethod]
        public void GetLibraryLocations_JsonLibrarySuccessResponse_CanDeserialize()
        {
            using (SimpleServer.Create(Response.RestResponse_Handler, "GetLibraryLocationsSuccessResponse.txt"))
            {
                // Arrange
                var client = new BiblioCommonsRestClient(false, false);

                // Act
                var result = client.GetLibraryLocations();

                // Assert
                Assert.IsTrue(result != null);
                Assert.AreEqual(237, result.locations.Count);
            }
        }
    }
}
