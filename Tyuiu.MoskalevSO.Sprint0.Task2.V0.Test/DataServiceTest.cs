using Tyuiu.MoskalevSO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MoskalevSO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            
            var name = "Степан";
            var res = DataService.GetMessage(name);


            Assert.AreEqual("Привет..., Степан", res);
        }
    }
}
