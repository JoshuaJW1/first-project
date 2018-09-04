using System;
using System.Media;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using  first_project;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTestSoundPlayer
    {
        Form1 myForm1 = new Form1();
        [TestMethod]
        public void TestMethod1()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resource1.m1_garand_clip);
            simpleSound.Play();
        }
        [TestMethod]
        public void TestMethod2()
        {
            SoundPlayer simpleSound = new SoundPlayer(Resource1.m1_garand);
            simpleSound.Play();
        }
    }
}
