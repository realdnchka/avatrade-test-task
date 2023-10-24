using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace AvatradeTestTask.POMs;

public class BasePom: IBasePom
{
    protected WebDriver driver;
    private WebDriverWait _wait;

    public BasePom(WebDriver driver)
    {
        this.driver = driver;
        _wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
    }

    public void WaitForLoadJs()
    {
        _wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));
    }

    public void WaitForElementExist(By selector)
    {
        try
        {
            WaitForLoadJs();
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(selector));
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
        }
    }

    public void Click(By selector)
    {
        WaitForElementExist(selector);
        driver.FindElement(selector).Click();
    }

    public bool IsVisible(By selector)
    {
        try
        {
            WaitForElementExist(selector);
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(selector));
            return true;
        }
        catch (NoSuchElementException)
        {
            return false;
        }
    }

    public void SendKeys(By selector, string text)
    {
        WaitForElementExist(selector);
        driver.FindElement(selector).SendKeys(text);
    }

    public void Clear(By selector)
    {
        throw new NotImplementedException();
    }
}