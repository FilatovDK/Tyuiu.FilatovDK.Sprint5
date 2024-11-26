using Tyuiu.FilatovDK.Sprint5.Task0.V27.Lib;
namespace Tyuiu.FilatovDK.Sprint5.Task0.V27.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            string path = @"C:\Users\fiirv\AppData\Local\Temp\OutPutFileTask0.txt";
            var res = ds.SaveToFileTextData(0);
            Assert.AreEqual(path, res);
        }
    }
}