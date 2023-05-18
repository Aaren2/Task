using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestTask17
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string text = "abc-абв.¿¡";
            int cost = 4;

            int res = Task17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod2()
        {
            string text = "‿︵‿ヽ(°□° )ノ︵‿︵";
            int cost = 14;

            int res = Task17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod3()
        {
            string text = "ʕ ᵔᴥᵔ ʔ";
            int cost = 7;

            int res = Task17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod4()
        {
            string text = "(ﾉ◕ヮ◕)ﾉ*:･ﾟ✧";
            int cost = 12;

            int res = Task17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }
        [TestMethod]
        public void TestMethod5()
        {
            string text = "ଲ(ⓛ ω ⓛ)ଲ";
            int cost = 9;

            int res = Task17.Program.Search(text);

            Assert.AreEqual(cost, res);
        }        
//　　　　 .,,..;~`””　　　　`””＜“彡　}
// 　_…:=,`’　　 　︵　 т　︵　　X彡-J
// ＜`　彡 /　　ミ　　,_人_.　＊彡　`~ 
//　 `~=::　　　 　　　　　　 　　　Y
// 　　 　i.　　　　　　　　　　　　 .:
// 　　　.\　　　　　　　,｡—.,,　　./
// 　　　　ヽ　／ﾞ”“`\;.{　　　 ＼／
// 　　　　　Y　　　`J..r_.彳　 　|
// 　　　　　{　　　“　　`　　　i
// 　　　　　\　　　　　　　　　＼　　　 ..︵︵.
// 　　　　　`＼　　　　　　　　　“ゞ.,/` oQ o`)
// 　　　　　　`i,　　　　　　　　　　Y　 ω　/
// 　　　　 　　`i,　　 　　.　　　　»　　　/
// 　　　　　　`iミ　　　　　　　　　　　,,ノ
// 　　　　 　 ︵Y..︵.,,　　　,,+..__ノ“
// 　　　　　(,`, З о　　　　,.ノ川彡ゞ彡
    }
}
