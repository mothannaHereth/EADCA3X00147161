using Microsoft.VisualStudio.TestTools.UnitTesting;
using static BlazorWeather.Pages.Index;

namespace UnitTestWeather
{
    [TestClass]
    public class UnitTestWeather
    {
        [TestMethod]
        public void TestWeather()
        {
            var objB = new BlazorWeather.Pages.Index();
            var obj =  objB.DoSearch("Tallaght");

            Assert.IsNotNull(BlazorWeather.Pages.Index.forecast, "Unit Test Successfully done");
        }
    }
}
