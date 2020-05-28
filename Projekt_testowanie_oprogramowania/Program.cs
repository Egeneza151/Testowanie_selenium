/*
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
*/
/*
namespace Projekt_testowanie_oprogramowania
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            //IWebDriver driver = new FirefoxDriver();
            makeTest(driver);
                     
        }

        static void makeTest(IWebDriver browser)
        {
            //browser.Navigate().GoToUrl("http://www.seleniumframework.com/Practiceform/");

            browser.Navigate().GoToUrl("http://newtours.demoaut.com/");

            IList<IWebElement> formElements = new List<IWebElement>();
            clearElementsInList(formElements);
            //Register
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[2]/a")).Click();
            //First Name
            IWebElement firstName = browser.FindElement(By.Name("firstName"));
            formElements.Add(firstName);
            //Last Name
            IWebElement lastName = browser.FindElement(By.Name("lastName"));
            formElements.Add(lastName);
            //Phone
            IWebElement phone = browser.FindElement(By.Name("phone"));
            formElements.Add(phone);
            //Email
            IWebElement userName = browser.FindElement(By.Name("userName"));
            formElements.Add(userName);
            //Adress1
            IWebElement address1 = browser.FindElement(By.Name("address1"));
            formElements.Add(address1);
            //Adress2
            IWebElement address2 = browser.FindElement(By.Name("address2"));
            formElements.Add(address2);
            //City
            IWebElement city = browser.FindElement(By.Name("city"));
            formElements.Add(city);
            //State/PRovince
            IWebElement state = browser.FindElement(By.Name("state"));
            formElements.Add(state);
            //Postal Code
            IWebElement postalCode = browser.FindElement(By.Name("postalCode"));
            formElements.Add(postalCode);
            //Country - select
            IWebElement country = browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/select/option[16]"));
            formElements.Add(country);
            //User Name
            IWebElement email = browser.FindElement(By.Name("email"));
            formElements.Add(email);
            //Password
            IWebElement password = browser.FindElement(By.Name("password"));
            formElements.Add(password);
            //Confirm Password
            IWebElement confirmPassword = browser.FindElement(By.Name("confirmPassword"));
            formElements.Add(confirmPassword);
            //Submit
            IWebElement register = browser.FindElement(By.Name("register"));


            //Rejestracja
            formElements[0].SendKeys("aaa");//fn
            formElements[1].SendKeys("bbb");//ln
            formElements[2].SendKeys("123456789");//ph
            formElements[3].SendKeys("aaa@aaa.com");//e@
            formElements[4].SendKeys("asdf");//a1
            formElements[5].SendKeys("zxcv");//a2
            formElements[6].SendKeys("qwer");//ci
            formElements[7].SendKeys("qwerty");//state
            formElements[8].SendKeys("34341");//pos
            formElements[9].Click();//country
            formElements[10].SendKeys("12345");//un
            formElements[11].SendKeys("12345!@#");//pass
            formElements[12].SendKeys("12345!@#");//repass


            register.Click();

            
            //Flight formularz
            //Flight
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[1] / table / tbody / tr / td / table / tbody / tr / td / table / tbody / tr[2] / td[2] / a")).Click();
            //Radio - 1 wiersz
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[2]/td[2]/b/font/input[2]")).Click();
            //Passengers
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[3]/td[2]/b/select/option[3]")).Click();
            //Departing From
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td[2]/select/option[9]")).Click();
            //Month
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[1]/option[6]")).Click();
            //Day
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td[2]/select[2]/option[15]")).Click();
            //Arriving in
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td[2]/select/option[4]")).Click();
            //Returning Month
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[1]/option[12]")).Click();
            //Returning Day
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[7]/td[2]/select[2]/option[29]")).Click();
            //Service class
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td[2]/font/font/input[1]")).Click();
            //Airline
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/select/option[4]")).Click();
            //Continue
            browser.FindElement(By.Name("findFlights")).Click();


            //2 continue
            //1 radio
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[1]/tbody/tr[9]/td[1]/input")).Click();
            //2 radio
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table[2]/tbody/tr[7]/td[1]/input")).Click();
            //Continue
            browser.FindElement(By.Name("reserveFlights")).Click();


            //3 continue
            //Passangers
            //1
            //First Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Adam");
            //Last Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[4]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Nowak");
            //Meal
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[4] / td / table / tbody / tr[2] / td[3] / select / option[6]")).Click();

            //2
            //First Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Jan");
            //Last Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Kowalski");
            //Meal
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[5]/td/table/tbody/tr[2]/td[3]/select/option[9]")).Click();

            //3
            //First Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Andrzej");
            //Last Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Brzoza");
            //Meal
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[6]/td/table/tbody/tr[2]/td[3]/select/option[5]")).Click();

            //Credit Card
            //Card Type
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[1] / select / option[4]")).Click();
            //Number
            browser.FindElement(By.XPath("/ html / body / div / table / tbody / tr / td[2] / table / tbody / tr[4] / td / table / tbody / tr / td[2] / table / tbody / tr[5] / td / form / table / tbody / tr[8] / td / table / tbody / tr[2] / td[2] / input")).SendKeys("2137");
            //Expiration Month
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[1]/option[11]")).Click();
            //Expiration Year
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[8]/td/table/tbody/tr[2]/td[3]/select[2]/option[7]")).Click();
            //First Name
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[1]/input")).SendKeys("Rafal");
            //Middle
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[2]/input")).SendKeys("Jhonson");
            //Last
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[9]/td/table/tbody/tr[2]/td[3]/input")).SendKeys("Paderewski");

            //Billing Address
            //Ticketless Travel
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[10]/td[2]/input")).Click();
            //Address 1
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[11]/td[2]/input")).SendKeys("2345 Twoj dom");
            //Address 2
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[12]/td[2]/input")).SendKeys("Sunshine");
            //City
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[13]/td[2]/input")).SendKeys("Sosnowiec");
            //State
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[1]")).SendKeys("MO");
            //Postal Code
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[14]/td[2]/input[2]")).SendKeys("34341");
            //Country
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[15]/td[2]/select/option[45]")).Click();
            //Delivery Address
            //Same as Billing Address
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[16]/td[2]/input")).Click();
            //Secure Purchase
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr/td[2]/table/tbody/tr[5]/td/form/table/tbody/tr[25]/td/input")).Click();
            //Logout
            browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[4]/td/table/tbody/tr[1]/td[2]/table/tbody/tr[7]/td/table/tbody/tr/td[3]/a")).Click();

            
            //Sign in
            //browser.FindElement(By.XPath("/html/body/div/table/tbody/tr/td[2]/table/tbody/tr[2]/td/table/tbody/tr/td[1]/a")).Click();
            */
            //Logowanie
            /*
            browser.FindElement(By.Name("userName")).SendKeys("12345");
            browser.FindElement(By.Name("password")).SendKeys("12345!@#");
            browser.FindElement(By.Name("login")).Click();
            */
            /*
            browser.Close();

        }
        static void clearElementsInList(IList<IWebElement> list)
        {
            foreach (var element in list)
            {
                element.Clear();
            }
        }
    }
}*/