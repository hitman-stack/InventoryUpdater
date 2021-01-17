using NUnit.Framework;
using InventoryUpdater;
using InventoryUpdater.Infrastructure;
using InventoryUpdater.Shared;
using System.Collections.Generic;
using System;

namespace InventoryUpdaterTest
{
    public class Tests
    {

        [TestFixture]
        public class InventoryUpdaterTest
        {

            [SetUp]
            public void SetUp()
            {
                
            }
            [Test]
            public void IsInputValid()
            {
                string input = "import capterra feed-products/capterra.yaml";
                var process = new ProductImporterProvider();
                var result = process.ProcessImporter(input,Constants.SOURCEMYSQL);
                Assert.AreEqual(typeof(List<string>), result.GetType());
                Assert.IsNotEmpty(input);
                Assert.IsNotEmpty(Constants.SOURCEMONGODB);
            }
            [Test]
            public void IsInputInValid()
            {
                string input = "import feed-products/capterra.yaml";
                var process = new ProductImporterProvider();
                Assert.Throws<FormatException>(() => process.Load(input));
            }
            [Test]
            public void IsDataSourceValid()
            {
                string input = "import capterra feed-products/capterra.yaml";
                string dataSource = "Postgress";
                var process = new ProductImporterProvider();
                Assert.Throws<InvalidOperationException>(() => process.ProcessImporter(input,dataSource));
            }
            [Test]
            public void IsExtensionValid()
            {
                string input = "import capterra feed-products/capterra.ya";
                var process = new ProductImporterProvider();
                Assert.Throws<FormatException>(() => process.Load(input));
            }
        }
    }
}