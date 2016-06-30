using System;
using Winium;
using OpenQA.Selenium.Winium;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Winium
{
    [TestClass]
    public class winiumtests
    {
        public DesktopOptions deskopts = new DesktopOptions();
        public IWiniumOptions opts;
        public WiniumDriver driver;

        [TestInitialize]
        public void TestInit()
        {            
            deskopts.ApplicationPath = "C:\\Windows\\System32\\notepad.exe";
            
        }

        [TestMethod]
        public void WiniumTest()
        {
            driver = new WiniumDriver(winiumDriverDirectory: "C://Winium",options:deskopts);
            //WiniumDriver driver = new WiniumDriver(new Uri("http://localhost:9999").ToString(), deskopts);
            driver.Keyboard.SendKeys("Alpha beta gamma delta");
        }


        [TestCleanup]
        public void CLeanUp()
        {
            driver.Close();   
        }
    }
}
