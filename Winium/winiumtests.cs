using System;
using System.Diagnostics;
using Winium;
using OpenQA.Selenium.Winium;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace Winium
{
    [TestClass]
    public class winiumtests
    {

        public DesktopOptions deskopts = new DesktopOptions();
        public IWiniumOptions opts;
        public WiniumDriver driver;

        private string appLocation = "c:\\windows\\System32\\calc.exe";

        private string screenshotDir = "C:\\temp\\";
        private int maxGames = 50; // how many times until we give up

        // run the inspector app
        // UI automation(not MSAA)
        // Options - > Content viiew


        // start the app here
        // saves time.
        [TestInitialize]
        public void TestInit()
        {            
            deskopts.ApplicationPath = "C:\\Windows\\System32\\notepad.exe";
            driver = new WiniumDriver(winiumDriverDirectory: "C://Winium", options: deskopts);
            //WiniumDriver driver = new WiniumDriver(new Uri("http://localhost:9999").ToString(), deskopts);   
            System.Threading.Thread.Sleep(1400); // wait a bit

        }

        [TestMethod]
        public void WiniumTest()
        {



            // start loo
            driver.Keyboard.SendKeys("Alpha beta gamma delta");
        }

        [TestMethod]
        public void TryMenus()
        {
            IWebElement winCore = driver.FindElementByClassName("Notepad");
            //var thisTHing = winCore.FindElement()
            winCore.FindElement(By.Name("Application")).Click(); // works
            winCore.FindElement(By.Name("File")).Click();
            Console.WriteLine("stop here");
        }


        /// <summary>
        /// interacts with the game
        /// 
        /// </summary>
        internal void InteractGame()
        {
            // wait a bit

            // handle missing ROM dialog(if it pops up)


            // if not, we're in


            // hit left

            // hit right


            // wait a bit

            

            // take screenshot

            // exit out(send ESC)




        }

        [TestCleanup]
        public void CLeanUp()
        {
            Trace.WriteLine("Shutting down app");  
            driver.Close();   
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("Class cleanup");
        }
    }
}
