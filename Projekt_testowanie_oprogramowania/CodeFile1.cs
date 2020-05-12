
            //Wejscie na strone
            browser.Navigate().GoToUrl("http://automationpractice.com/index.php");
            //T-shirts
            browser.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a")).Click();
            //Catalog - S
            //*[@id="layered_id_attribute_group_1"]
            //*[@id="ul_layered_id_attribute_group_1"]/li[1]/label/a
            //*[@id="uniform-layered_id_attribute_group_1"]/span
            browser.FindElement(By.Id("layered_id_attribute_group_1")).Click();
            //Color - Orange
            //*[@id="ul_layered_id_attribute_group_3"]/li[1]/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_id_attribute_group_3']/li[1]/label/a")).Click();
            //Kompozycja
            //*[@id="ul_layered_id_feature_5"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_id_feature_5']/li/label/a")).Click();
            //Styl
            //*[@id="ul_layered_id_feature_6"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_id_feature_6']/li/label/a")).Click();
            //Wlasciwosci
            //*[@id="ul_layered_id_feature_7"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_id_feature_7']/li/label/a")).Click();
            //Dostepnosc
            //*[@id="ul_layered_quantity_0"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_quantity_0']/li/label/a")).Click();
            //Manufaktura
            //*[@id="ul_layered_manufacturer_0"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_manufacturer_0']/li/label/a")).Click();
            //Nowe
            //*[@id="ul_layered_condition_0"]/li/label/a
            browser.FindElement(By.XPath("//*[@id='ul_layered_condition_0']/li/label/a")).Click();
            //Lista
            //*[@id="list"]/a
            browser.FindElement(By.XPath("//*[@id='list']/a")).Click();
            //Sortowanie - Product Name: A to Z
            //*[@id="selectProductSort"]
            browser.FindElement(By.XPath("//*[@id='selectProductSort']")).Click();
            //Option
            //*[@id="selectProductSort"]/option[4]
            browser.FindElement(By.XPath("//*[@id='selectProductSort']/option[4]")).Click();
            //Add to cart
            //*[@id="center_column"]/ul/li/div/div[2]/div[2]/a[1]

            //Close window (cart)
            //*[@id="layer_cart"]/div[1]/div[1]/span

            //More
            //*[@id="center_column"]/ul/li/div/div[2]/div[2]/a[2]

            //Big image
            //*[@id="thumb_2"]

            //Close window (img)
            //*[@id="product"]/div[2]/div/div/a

            //Quantity
            //*[@id="quantity_wanted"]

            //Add to cart (in element)
            //*[@id="add_to_cart"]/button
            


//Wejscie na OLX
browser.Navigate().GoToUrl("http://www.olx.pl/");
//Klikniecie w "Wiecej opcji"
browser.FindElement(By.Id("advertPreference")).Click();
//Zamkniecie opcji
browser.FindElement(By.XPath("//a[@aria-label='Zamknij okno']")).Click();
//Zamkniecie cookiesow
browser.FindElement(By.ClassName("cookie-close")).Click();
//Wybranie opcji elektronika
browser.FindElement(By.XPath("//*[@href='https://www.olx.pl/elektronika/']")).Click();
//Przejscie do wyszukiwania konkretnego komputera
browser.FindElement(By.XPath("//*[@href='https://www.olx.pl/elektronika/komputery/']")).Click();

//Testowanie formularza

//Przygotowanie elementów do testowania
IList <IWebElement> formElements = new List<IWebElement>();
//Zakres - niekoniecznie
IWebElement zakres = browser.FindElement(By.XPath("//*[@id='distanceSelect']/dd/ul/li[5]/a"));
formElements.Add(zakres);
//Zdjecie
//IWebElement zdjecie = browser.FindElement(By.XPath("//*[@id='photo - only']"));
//formElements.Add(zdjecie);
//Rodzaj - stacjonarne
//IWebElement rodzaj = browser.FindElement(By.XPath("//*[@id='param_subcat']/div[2]/a/span[1]"));
//IWebElement rodzaj = browser.FindElement(By.XPath("//*[@id='param_subcat']/div[2]/a/span[1]"));
//formElements.Add(rodzaj);
//Stan
//IWebElement stan = browser.FindElement(By.XPath("//*[@id='f - new_state']"));
//formElements.Add(stan);
//Cena od
IWebElement cenaod = browser.FindElement(By.XPath("//*[@id='param_price']/div[2]/input"));
formElements.Add(cenaod);
//Cena do
IWebElement cenado = browser.FindElement(By.XPath("//*[@id='param_price']/div[2]/div[2]/label/input"));
formElements.Add(cenado);
//Sortowanie po najtansze/najdrozsze/najnowsze
IWebElement sortuj = browser.FindElement(By.XPath("//*[@id='targetorder - select - gallery']/dd/ul/li[2]/a"));
formElements.Add(sortuj);
//Szukaj
IWebElement szukaj = browser.FindElement(By.XPath("//*[@id='search - submit']"));
//formElements.Add(szukaj);



//Przypadek wpisania blednych wartosci
clearElementsInList(formElements);
formElements[0].Click();//zakres
//formElements[1];//zdjecie
formElements[2].SendKeys("Komputery stacjonarne");//rodzaj
formElements[3].Click();//stan
formElements[4].SendKeys("10");//cena od
formElements[5].SendKeys("1250");//cena do
formElements[6].Click();//sortowanie
//formElements[7].Click();//submit


//Przypadek wpisania prawid³owych wartoœci
clearElementsInList(formElements);
formElements[0].SendKeys("name");
formElements[1].SendKeys("aaa@aaa.com");
formElements[2].SendKeys("123456789");
formElements[3].SendKeys("country");
formElements[4].SendKeys("company");
formElements[5].SendKeys("message");


//Otwarcie drugiego okna bezpoœrednio za pomoc¹ funkcji javascript
IJavaScriptExecutor js = (IJavaScriptExecutor)browser;
try
{
    js.ExecuteScript("newMsgWin()");
}
catch
{

}  


//Testujemy iloœæ okien, by zobaczyæ czy s¹ otwarte
IList<string> allWindowHandles = browser.WindowHandles;

Assert.True(allWindowHandles.Count == 3);


string newWindow;
try
{
    //Zamykamy dodatkowe okna i wracamy do g³ównego
    newWindow = allWindowHandles[1];
    browser.SwitchTo().Window(newWindow);
    browser.Close();
    newWindow = allWindowHandles[2];
    browser.SwitchTo().Window(newWindow);
    browser.Close();
    newWindow = allWindowHandles[0];
    browser.SwitchTo().Window(newWindow);
}
catch
{
}

//Testujemy formularz

//Przygotowanie elementów
IList <IWebElement> formElements = new List<IWebElement>();
IWebElement name = browser.FindElement(By.Name("name"));
formElements.Add(name);
IWebElement email = browser.FindElement(By.XPath("//input[@placeholder='E-mail *']"));
formElements.Add(email);
IWebElement telephone = browser.FindElement(By.Name("telephone"));
formElements.Add(telephone);
IWebElement country = browser.FindElement(By.Name("country"));
formElements.Add(country);
IWebElement company = browser.FindElement(By.Name("company"));
formElements.Add(company);
IWebElement message = browser.FindElement(By.Name("message"));
formElements.Add(message);

IWebElement submit = browser.FindElement(By.ClassName("dt-btn-submit"));


//Przypadek wpisania b³êdnych wartoœci
clearElementsInList(formElements);
formElements[0].SendKeys("name");
formElements[1].SendKeys("e-mail");
formElements[2].SendKeys("telephone");
formElements[3].SendKeys("country");
formElements[4].SendKeys("company");
formElements[5].SendKeys("message");

submit.Click();
try
{
    IWebElement errorPopUp0 = browser.FindElement(By.ClassName("form-validation-field-1formError"));
    IWebElement errorPopUp1 = browser.FindElement(By.ClassName("form-validation-field-2formError"));
    //Testujemy czy s¹ wyœwietlane komunikaty b³êdów
    Assert.True(errorPopUp0.Displayed);
    Assert.True(errorPopUp1.Displayed);

    //Usuwamy popupy poprzez klikniêcie na nie
    errorPopUp0.Click();
    errorPopUp1.Click();
}
catch
{

}

//Przypadek wpisania prawid³owych wartoœci
clearElementsInList(formElements);
formElements[0].SendKeys("name");
formElements[1].SendKeys("aaa@aaa.com");
formElements[2].SendKeys("123456789");
formElements[3].SendKeys("country");
formElements[4].SendKeys("company");
formElements[5].SendKeys("message");

submit.Click();
try
{
    browser.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
    IWebElement sucessPopUp0 = browser.FindElement(By.ClassName("greenPopup"));
    //Testujemy czy s¹ wyœwietlany komunikaty sukcesu
    Assert.True(sucessPopUp0.Displayed);

    //Usuwamy popup poprzez klikniêcie na niego
    sucessPopUp0.Click();
}
catch
{

}



browser.Close();