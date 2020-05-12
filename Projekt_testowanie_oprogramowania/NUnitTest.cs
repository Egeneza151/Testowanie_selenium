using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace Projekt_testowanie_oprogramowania
{
    class NUnitTest
    {
        IWebDriver driver;
        /*public void TestApp()
        {
            Initialize();
            OpenAppTest();
            EndTest();
        }*/

        [SetUp]
        public void Initialize()
        {
            //driver = new ChromeDriver();
            //driver = new FirefoxDriver();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://automationpractice.com/index.php";
        }

        [Test]
        public void OpenAppTest2()
        {
            driver.Url = "http://ux.up.krakow.pl/~mazela";
        }


        [TearDown]
        public void EndTest()
        {
            //driver.Close();
        }
    }
}
