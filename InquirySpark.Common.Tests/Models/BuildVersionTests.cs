﻿using InquirySpark.Common.Models;
using System.Reflection;

namespace InquirySpark.Common.Tests.Models
{
    [TestClass]
    public class BuildVersionTests
    {
        [TestMethod]
        public void BuildVersionToString_ExpectedBehavior()
        {
            // Arrange
            var buildVersion = new BuildVersion(Assembly.GetExecutingAssembly()?.GetName().Version);

            // Act
            var result = buildVersion.ToString();

            // Assert
            Assert.IsNotNull(result);
        }
    }
}
