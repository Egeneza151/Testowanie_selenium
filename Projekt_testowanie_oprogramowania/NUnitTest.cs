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
        IWebDriver browser;
        IList<IWebElement> formElements = new List<IWebElement>();
        static void Main() { }
        public void TestApp()
        {
            Initialize();
            OpenAppTest01();
            OpenAppTest02();
            OpenAppTest03();
            OpenAppTest04();
            OpenAppTest05();
            OpenAppTest06();
            OpenAppTest07();
            OpenAppTest08();
            OpenAppTest09();
            OpenAppTest10();
            OpenAppTest11();
            EndTest();
        }

        [OneTimeSetUp]
        public void Initialize()
        {
            browser = new ChromeDriver();
            //browser = new FirefoxDriver();
            browser.Navigate().GoToUrl("http://newtours.demoaut.com/");
            clearElementsInList(formElements);
            

        }

        [Test]
        public void OpenAppTest01()//Find elements
        {
            //Register
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a")).Click();
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a")));
            //First Name
            IWebElement firstName = browser.FindElement(By.Name("firstName"));
            Assert.IsNotNull(firstName);
            formElements.Add(firstName);
            //Last Name
            IWebElement lastName = browser.FindElement(By.Name("lastName"));
            Assert.IsNotNull(lastName);
            formElements.Add(lastName);
            //Phone
            IWebElement phone = browser.FindElement(By.Name("phone"));
            Assert.IsNotNull(phone);
            formElements.Add(phone);
            //Email
            IWebElement userName = browser.FindElement(By.Name("userName"));
            Assert.IsNotNull(userName);
            formElements.Add(userName);
            //Adress1
            IWebElement address1 = browser.FindElement(By.Name("address1"));
            Assert.IsNotNull(address1);
            formElements.Add(address1);
            //Adress2
            IWebElement address2 = browser.FindElement(By.Name("address2"));
            Assert.IsNotNull(address2);
            formElements.Add(address2);
            //City
            IWebElement city = browser.FindElement(By.Name("city"));
            Assert.IsNotNull(city);
            formElements.Add(city);
            //State/PRovince
            IWebElement state = browser.FindElement(By.Name("state"));
            Assert.IsNotNull(state);
            formElements.Add(state);
            //Postal Code
            IWebElement postalCode = browser.FindElement(By.Name("postalCode"));
            Assert.IsNotNull(postalCode);
            formElements.Add(postalCode);
            //Country - select
            IWebElement country = browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/select/option[16]"));
            Assert.IsNotNull(country);
            formElements.Add(country);
            //User Name
            IWebElement email = browser.FindElement(By.Name("email"));
            Assert.IsNotNull(email);
            formElements.Add(email);
            //Password
            IWebElement password = browser.FindElement(By.Name("password"));
            Assert.IsNotNull(password);
            formElements.Add(password);
            //Confirm Password
            IWebElement confirmPassword = browser.FindElement(By.Name("confirmPassword"));
            Assert.IsNotNull(confirmPassword);
            formElements.Add(confirmPassword);
            //Submit
            IWebElement register = browser.FindElement(By.Name("register"));
            Assert.IsNotNull(register);
            formElements.Add(register);


        }

        [Test]
        public void OpenAppTest02()//Add values
        {
            //Rejestracja
            formElements[0].SendKeys("aaa");//fn
            Assert.AreEqual("aaa", formElements[0].GetAttribute("value"));
            formElements[1].SendKeys("bbb");//ln
            Assert.AreEqual("bbb", formElements[1].GetAttribute("value"));
            formElements[2].SendKeys("123456789");//ph
            Assert.AreEqual("123456789", formElements[2].GetAttribute("value"));
            formElements[3].SendKeys("aaa@aaa.com");//e@
            Assert.AreEqual("aaa@aaa.com", formElements[3].GetAttribute("value"));
            formElements[4].SendKeys("asdf");//a1
            Assert.AreEqual("asdf", formElements[4].GetAttribute("value"));
            formElements[5].SendKeys("zxcv");//a2
            Assert.AreEqual("zxcv", formElements[5].GetAttribute("value"));
            formElements[6].SendKeys("qwer");//ci
            Assert.AreEqual("qwer", formElements[6].GetAttribute("value"));
            formElements[7].SendKeys("qwerty");//state
            Assert.AreEqual("qwerty", formElements[7].GetAttribute("value"));
            formElements[8].SendKeys("34341");//pos
            Assert.AreEqual("34341", formElements[8].GetAttribute("value"));
            formElements[9].Click();//country
            formElements[10].SendKeys("12345");//un
            Assert.AreEqual("12345", formElements[10].GetAttribute("value"));
            formElements[11].SendKeys("12345!@#");//pass
            Assert.AreEqual("12345!@#", formElements[11].GetAttribute("value"));
            formElements[12].SendKeys("12345!@#");//repass
            Assert.AreEqual("12345!@#", formElements[12].GetAttribute("value"));
            formElements[13].Click();//register

        }

        [Test]
        public void OpenAppTest03()//Test flight form
        {
            //Flight formularz
            //Flight
            Assert.IsNotNull(browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[1] / table / tbody / tr / td / table / tbody / tr / td / table / tbody / tr[2] / td[2] / a")));
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[1] / table / tbody / tr / td / table / tbody / tr / td / table / tbody / tr[2] / td[2] / a")).Click();
            //Radio - 1 wiersz
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]")).Click();
            //Passengers
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select/option[3]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select/option[3]")).Click();
            //Departing From
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/select/option[9]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/select/option[9]")).Click();
            //Month
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[1]/option[6]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[1]/option[6]")).Click();
            //Day
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[2]/option[15]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[2]/option[15]")).Click();
            //Arriving in
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td[2]/select/option[4]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td[2]/select/option[4]")).Click();
            //Returning Month
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[1]/option[12]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[1]/option[12]")).Click();
            //Returning Day
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[2]/option[29]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[2]/option[29]")).Click();
            //Service class
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[1]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[1]")).Click();
            //Airline
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/select/option[4]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/select/option[4]")).Click();
            
            //Continue
            Assert.IsNotNull(browser.FindElement(By.Name("findFlights")));
            browser.FindElement(By.Name("findFlights")).Click();
        }



        [Test]
        public void OpenAppTest04()//Test second form
        {
            //2 continue
            //1 radio
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[1]/tbody/tr[9]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[1]/tbody/tr[9]/td[1]/input")).Click();
            //2 radio
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[2]/tbody/tr[7]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[2]/tbody/tr[7]/td[1]/input")).Click();
            //Continue
            Assert.IsNotNull(browser.FindElement(By.Name("reserveFlights")));
            browser.FindElement(By.Name("reserveFlights")).Click();
        }

        [Test]
        public void OpenAppTest05()//Test third form #1
        {
            //3 continue
            //Passangers
            //1
            //First Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Adam");
            Assert.AreEqual("Adam", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[1]/input")).GetAttribute("value"));
            //Last Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Nowak");
            Assert.AreEqual("Nowak", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input")).GetAttribute("value"));
            //Meal
            Assert.IsNotNull(browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[4] / td / table / tbody / tr[2] / td[3] / select / option[6]")));
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[4] / td / table / tbody / tr[2] / td[3] / select / option[6]")).Click();

        }

        [Test]
        public void OpenAppTest06()//Test third form #2
        {
            //2
            //First Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Jan");
            Assert.AreEqual("Jan", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[1]/input")).GetAttribute("value"));
            //Last Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Kowalski");
            Assert.AreEqual("Kowalski", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/input")).GetAttribute("value"));
            //Meal
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[3]/select/option[9]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[3]/select/option[9]")).Click();
        }

        [Test]
        public void OpenAppTest07()//Test third form #3
        {
            //3
            //First Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Andrzej");
            Assert.AreEqual("Andrzej", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[1]/input")).GetAttribute("value"));
            //Last Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Brzoza");
            Assert.AreEqual("Brzoza", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[2]/input")).GetAttribute("value"));
            //Meal
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[3]/select/option[5]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[3]/select/option[5]")).Click();
        }

        [Test]
        public void OpenAppTest08()//Test credit card
        {
            //Credit Card
            //Card Type
            Assert.IsNotNull(browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[1] / select / option[4]")));        
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[1] / select / option[4]")).Click();
            //Number
            Assert.IsNotNull(browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[2] / input")));
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[2] / input")).SendKeys("2137");
            Assert.AreEqual("2137", browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[2] / input")).GetAttribute("value"));
            //Expiration Month
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[1]/option[11]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[1]/option[11]")).Click();
            //Expiration Year
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[2]/option[7]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[2]/option[7]")).Click();
            //First Name
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[1]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Rafal");
            Assert.AreEqual("Rafal", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[1]/input")).GetAttribute("value"));
            //Middle
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Jhonson");
            Assert.AreEqual("Jhonson", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[2]/input")).GetAttribute("value"));
            //Last
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[3]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[3]/input")).SendKeys("Paderewski");
            Assert.AreEqual("Paderewski", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[3]/input")).GetAttribute("value"));
        }

        [Test]
        public void OpenAppTest09()//Test billing address
        {
            //Billing Address
            //Ticketless Travel
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input")).Click();
            //Address 1
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/input")).Clear();
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/input")).SendKeys("2345 Twoj dom");
            Assert.AreEqual("2345 Twoj dom", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/input")).GetAttribute("value"));
            //Address 2
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input")).Clear();
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input")).SendKeys("Sunshine");
            Assert.AreEqual("Sunshine", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input")).GetAttribute("value"));
            //City
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input")).Clear();
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input")).SendKeys("Sosnowiec");
            Assert.AreEqual("Sosnowiec", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input")).GetAttribute("value"));
            //State
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[1]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[1]")).Clear();
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[1]")).SendKeys("MO");
            Assert.AreEqual("MO", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[1]")).GetAttribute("value"));
            //Postal Code
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[2]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[2]")).Clear();
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[2]")).SendKeys("34341");
            Assert.AreEqual("34341", browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[2]")).GetAttribute("value"));
            //Country
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[15]/td[2]/select/option[45]")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[15]/td[2]/select/option[45]")).Click();
        }

        [Test]
        public void OpenAppTest10()//Test delivery address
        {
            //Delivery Address
            //Same as Billing Address
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[16]/td[2]/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[16]/td[2]/input")).Click();
            //Secure Purchase
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[25]/td/input")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[25]/td/input")).Click();
            //Logout
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[7]/td/table/tbody/tr/td[3]/a")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[7]/td/table/tbody/tr/td[3]/a")).Click();

        }

        [Test]
        public void OpenAppTest11()//Test login
        {
            //Sign in
            Assert.IsNotNull(browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a")));
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a")).Click();
            //Logowanie

            Assert.IsNotNull(browser.FindElement(By.Name("userName")));
            browser.FindElement(By.Name("userName")).SendKeys("12345");
            Assert.AreEqual("12345", browser.FindElement(By.Name("userName")).GetAttribute("value"));
            Assert.IsNotNull(browser.FindElement(By.Name("password")));
            browser.FindElement(By.Name("password")).SendKeys("12345!@#");
            Assert.AreEqual("12345!@#", browser.FindElement(By.Name("password")).GetAttribute("value"));
            Assert.IsNotNull(browser.FindElement(By.Name("login")));
            browser.FindElement(By.Name("login")).Click();


        }


        
        [TearDown]
        public void EndTest()
        {
            //browser.Close();
        }

        static void clearElementsInList(IList<IWebElement> list)
        {
            foreach (var element in list)
            {
                element.Clear();
            }
        }
    }
}
