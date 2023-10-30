using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace AvatradeTestTask.Tests;

public class BaseTest
{
    protected IWebDriver driver;
    private string _url = "https://www.avatrade.com/?mode=test-static-widget";
    
    [TestInitialize]
    public void SetUp()
    {
        driver = new ChromeDriver();
        var options = new ChromeOptions();
        options.AddArgument("no-sandbox");
        driver.Manage().Timeouts().PageLoad.Add(System.TimeSpan.FromSeconds(30));
        driver.Navigate().GoToUrl(_url);
    }

    [TestCleanup]
    public void TearDown()
    {
        driver.Quit();
    }
}