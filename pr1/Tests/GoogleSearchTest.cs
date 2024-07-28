using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace pr1.Tests
{

    [TestFixture]

    public class GoogleSearchTest

    {

        private IWebDriver driver;
        private IWait<IWebDriver> wait;


        public GoogleSearchTest()

        {



        }



        [SetUp]

        public void SetUp()

        {

            string path = "T:\\הנדסת תוכנה\\שנה ב\\קבוצה ב\\תלמידות\\מירי בלאקר\\pr1\\pr1\\Drivers";



            //Creates the ChomeDriver object, Executes tests on Google Chrome



            driver = new ChromeDriver(path );

            driver.Manage().Window.Maximize();

        }



        [Test]

        public void TestGoogleSearch()

        {

            // Step 1: Navigate to Google

            driver.Navigate().GoToUrl("https://www.google.com");



            // Step 2: Verify the title of the page

            Assert.AreEqual("Google", driver.Title);



            // Step 3: Find the search box using its name attribute

            IWebElement searchBox = driver.FindElement(By.Name("q"));



            // Step 4: Enter the search term and submit the search

            searchBox.SendKeys("Selenium WebDriver");

            // step 5:

            searchBox.Submit();

            // step 6: Wait for the results page to load and verify the title

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10.00));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"rso\"]/div[1]/div/div/div/div/div/div/div/div[1]/div/span/a/h3/span")));

            //step 7:

            //List<WebElement> res = (List<WebElement>)driver.FindElement(By.CssSelector(".r"));
            //Assert.IsNotNull(res);

            //// step 8:
            //driver.FindElements()
        }
        [TearDown] public void TearDown()
        {
            driver.Dispose();
        }
    }
}
