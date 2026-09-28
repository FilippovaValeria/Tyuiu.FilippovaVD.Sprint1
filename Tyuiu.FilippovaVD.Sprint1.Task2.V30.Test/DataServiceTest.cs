using Tyuiu.FilippovaVD.Sprint1.Task2.V30.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task2.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 1;
            var res = ds.ConvertKmToMetre(x);
            Assert.AreEqual(1000, res);
        }
    }
}
