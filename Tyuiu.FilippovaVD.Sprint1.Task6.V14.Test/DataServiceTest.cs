using Tyuiu.FilippovaVD.Sprint1.Task6.V14.Lib;
namespace Tyuiu.FilippovaVD.Sprint1.Task6.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidString()
        {
            DataService ds = new DataService();

            string validInput = "приветмир";
            bool result1 = ds.CheckLowerCaseRusLetters(validInput);
            Assert.IsTrue(result1);

            string invalidInput1 = "Привет";
            bool result2 = ds.CheckLowerCaseRusLetters(invalidInput1);
            Assert.IsFalse(result2);

            string invalidInput2 = "привет мир";
            bool result3 = ds.CheckLowerCaseRusLetters(invalidInput2);
            Assert.IsFalse(result3);

            string invalidInput3 = "hello";
            bool result4 = ds.CheckLowerCaseRusLetters(invalidInput3);
            Assert.IsFalse(result4);


        }
    }
}
