using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Winium;

namespace HelloWorldTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            DesktopOptions option = new DesktopOptions();

            option.ApplicationPath = (@"C:\Users\Ch4initus\Desktop\Test\HelloWorld.exe");

            WiniumDriver driver = new WiniumDriver(@"C:\Users\Ch4initus\Desktop", option);

            driver.FindElementByClassName("WindowsForms10.EDIT.app.0.2bf8098_r13_ad1").SendKeys("Hoàng Quốc Trung 1512609");

            driver.FindElementByClassName("WindowsForms10.BUTTON.app.0.2bf8098_r13_ad1").Click();

            driver.Quit();
        }
    }
}
