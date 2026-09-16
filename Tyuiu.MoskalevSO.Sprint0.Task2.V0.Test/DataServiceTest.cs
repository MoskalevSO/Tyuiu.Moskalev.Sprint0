using Tyuiu.MoskalevSO.Sprint0.Task2.V0.Lib;

namespace Tyuiu.MoskalevSO.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            // Область создания методов тестирования, методов из библиотеки
            var name = "рыба";
            var res = DataService.GetMessage(name);

            //Вызываем класс Assert и метод AreEqual
            Assert.AreEqual("Привет..., рыба", res);
        }
    }
}
