using NUnit.Framework;
using NedraStreamSamsonovLev;

namespace NedraStreamSamsonovLev.Test
{
    
    public class Tests
    {
        private Tree _tree1 = new Tree();
        private Tree _tree2 = new Tree();

        private int _answer1 = 490;
        private int _answer2 = 400;

        [SetUp]
        public void Setup()
        {
            //       100 
            //   50       150
            // 10  60   110  150
            //        105 130
            _tree1.Add(100);
            _tree1.Add(50);
            _tree1.Add(150);
            _tree1.Add(10);
            _tree1.Add(60);
            _tree1.Add(110);
            _tree1.Add(150);
            _tree1.Add(105);
            _tree1.Add(130);

            //       100 
            //   50       150
            // 10  60   110  150
            _tree2.Add(100);
            _tree2.Add(50);
            _tree2.Add(150);
            _tree2.Add(10);
            _tree2.Add(60);
            _tree2.Add(110);
            _tree2.Add(150);
        }

        [Test]
        public void GetMaxSum_Use_tree1_Return_answer1()
        {

            Assert.AreEqual(_answer1, _tree1.GetMaxSum());
        }
        [Test]
        public void GetMaxSum_Use_tree2_Return_answer2()
        {

            Assert.AreEqual(_answer2, _tree2.GetMaxSum());
        }
    }
}