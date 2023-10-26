using InquirySpark.Common.Models;
using System.Reflection;

namespace InquirySpark.Common.Tests.Models;

[TestClass]
public class ApplicationStatusTests
{
    [TestMethod]
    public void Test_ApplicationStatus_ExpectedBehavior()
    {
        // Arrange
        var applicationStatus = new ApplicationStatus(Assembly.GetExecutingAssembly());

        var mytest = applicationStatus.BuildVersion.ToString();

        // Act

        // Assert
        Assert.IsNotNull(applicationStatus);
        Assert.IsNotNull(mytest);
    }
}
