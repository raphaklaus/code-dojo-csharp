using CodeDojoJokenpo;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace JudgeTest
{
    
    
    /// <summary>
    ///This is a test class for JudgeTest and is intended
    ///to contain all JudgeTest Unit Tests
    ///</summary>
    [TestClass()]
    public class JudgeTest
    {

        [TestMethod()]
        public void JudgeConstructorTest()
        {

            string expected = "Rock Wins."; // I want this test fail. Eu quero que este teste falhe.

            Judge TheJudge = new Judge();

            Judge_Accessor target = new Judge_Accessor();
            Assert.AreEqual(expected, TheJudge.doJudge("Paper","Rock"));

            
        }
    

        [TestMethod()]
        public void JudgeConstructorTest2()
        {

            string expected = "Draw Game!"; // Test the draw game! Teste o empate de jogo!

            Judge TheJudge = new Judge();
            Assert.AreEqual(expected, TheJudge.doJudge("Rock", "Rock"));


        }


        [TestMethod()]
        public void JudgeConstructorTest3()
        {

            string expected3 = "Scissors Wins."; // Scissors must win, test it for me, plz! Tesoura deve ganhar, teste pra aí, pfv!

            Judge TheJudge = new Judge();
            Assert.AreEqual(expected3, TheJudge.doJudge("Paper", "Scissors"));


        }

    }
}
