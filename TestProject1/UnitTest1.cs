using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApplication11.Repository;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            WeatherRepository weatherRepository = new WeatherRepository();
            var data = weatherRepository.GetData();

            Assert.IsNotNull(data);
        }
    }
}
