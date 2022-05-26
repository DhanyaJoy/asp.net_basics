
namespace TestProject1
{
    [TestClass]
    public class Adder_add
    {
        [TestMethod]
        public void inputs2and3()
        {
            WebApplication1.Adder a = new WebApplication1.Adder();
           int result= a.add(2,3);
            Assert.AreEqual(5,result);
           
        }
        [TestMethod]
        public void input5and9()
        {
            WebApplication1.Adder a = new WebApplication1.Adder();
            int result = a.add(5,9);
            Assert.AreEqual(14, result);

        }
        [TestMethod]
        public void input15and9()
        {
            WebApplication1.Adder a = new WebApplication1.Adder();
            int result = a.add(15,9);
            Assert.AreEqual(24, result);

        }
        [TestMethod]
        public void inputminus5and10()
        {
            WebApplication1.Adder a = new WebApplication1.Adder();
            int result = a.add(-5,10);
            Assert.AreEqual(5, result);

        }
    }
}