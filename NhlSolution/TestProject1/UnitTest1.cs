namespace TestProject1
{
    using NhlSystemClassLibrary;

    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [DataRow(97,"Connor McDavid", Position.C)]
        [DataRow(93, "Ryan Nugent-Hopkins", Position.C)]
        [DataRow(91, "Evander Kane", Position.LW)]
        public void TestMethod1()
        {
        }
    }
}