using Tyuiu.FilippovaVD.Sprint1.Task3.V9.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task3.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 90;
            var res = ds.ConvertMinutesToHours(x);
            Assert.AreEqual(1.5, res);
        }
    }
}
