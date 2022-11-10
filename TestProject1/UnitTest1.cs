using StudentServiceLib;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Student abc = new Student();

            abc.Score = 8.0;

            char letter = abc.getLetterScore();
            Assert.AreEqual('A',letter);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Student abc = new Student();

            abc.Score = 7.0;

            char letter = abc.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void TestMethod3()
        {
            Student abc = new Student();

            abc.Score = 6.0;

            char letter = abc.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void TestMethod4()
        {
            Student abc = new Student();

            abc.Score = 3.5;

            char letter = abc.getLetterScore();
            Assert.AreEqual('D', letter);
        }

        [TestMethod]
        public void TestScore()
        {
            Student st = new Student();
            bool thrown = false;
            try
            {
                st.Score = 11;
            }
            catch(SystemException e)
            {
                thrown = true;
            }
            Assert.IsTrue(thrown);
        }

        public void TestScore1()
        {
            Student st = new Student();
            bool thrown = false;
            try
            {
                st.Score = -2;
            }
            catch (SystemException e)
            {
                thrown = true;
            }
            Assert.IsTrue(thrown);
        }
    }
}