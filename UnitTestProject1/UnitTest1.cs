using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Winium;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {


        [TestMethod]
        public void TestNotePad()
        {
            DesktopOptions options = new DesktopOptions();
            options.ApplicationPath = @"C:\Windows\notepad.exe";
            WiniumDriver driver = new WiniumDriver(@"C:\Users\Eletronica10\source\repos\UnitTestProject1\UnitTestProject1",options);//Winium.Desktop.Driver.exe
            driver.FindElementByClassName("Edit").SendKeys("hello world");
        }
    }
}
