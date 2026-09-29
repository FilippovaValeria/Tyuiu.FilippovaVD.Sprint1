using Tyuiu.FilippovaVD.Sprint1.Task4.V16.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task4.V16.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 6;
            double wait = 0.1;
            var res = ds.Calculate(x);
            Assert.AreEqual(wait, res);
        }
    }
}
