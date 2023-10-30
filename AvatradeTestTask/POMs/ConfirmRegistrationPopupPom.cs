using OpenQA.Selenium;

namespace AvatradeTestTask.POMs;

public class ConfirmRegistrationPopupPom: BasePom
{
    public ConfirmRegistrationPopupPom(WebDriver driver) : base(driver) { }
    
    //selectors
    private By _firstNameInput = By.XPath("//input[@name='FirstName']");
    private By _lastNameInput = By.XPath("//input[@name='LastName']");
    private By _birthdayInput = By.XPath("//input[@name='date-of-birth-day']");
    private By _countryInput = By.XPath("//input[@name='Country']");
    private By _countryOption = By.XPath("//div[@role='option']//span[@class='country-name']");
    private By _cityInput = By.XPath("//input[@name='City']");
    private By _streetNameInput = By.XPath("//input[@name='Street']");
    private By _buildingNumberInput = By.XPath("//input[@name='BuildingNumber']");
    private By _zipCodeInput = By.XPath("//input[@name='ZipCode']");
    private By _phoneNumberInput = By.XPath("//input[@name='Phone']");
    private By _continueButton = By.XPath("//button[@type='submit']");
    private By _selectOption(string option) => By.XPath($"//div[contains(@class, 'v-list-item__title') and contains(text(), '{option}')]");
    private By _occupationOrBusinessSelect = By.XPath("//div[@data-automation='OccupationOrBusiness']");
    private By _employmentStatusSelect = By.XPath("//div[@data-automation='EmploymentStatus']");
    private By _sourceOfTradeFundsSelect = By.XPath("//div[@data-automation='SourceOfTradeFunds']");
    private By _estimatedAnnualIncomeSelect = By.XPath("//div[@data-automation='EstimatedAnnualIncome']");
    private By _savingsAndInvestmentsSelect = By.XPath("//div[@data-automation='SavingsAndInvestments']");
    private By _amountIntendInvestingEveryYearSelect = By.XPath("//div[@data-automation='AmountIntendInvestingEveryYear']");
    
    private By _relevantExperienceYesButton = By.XPath("//label/span[contains(text(), 'Yes')]");
    private By _relevantExperienceNoButton = By.XPath("//label/span[contains(text(), 'No')]");
    private By _numOfTimesTradingSelect = By.XPath("//div[@data-automation='NumOfTimesTradedinForexCfds']");
    private By _whatWasTheAverageSizeOfTradesSelect = By.XPath("//div[@data-automation='WhatWasTheAverageSizeOfTrades']");
    private By _tradingWithLeverageAppliesSelect = By.XPath("//div[@data-automation='TradingWithLeverageApplies']");
    private By _tradingWithLeverageMaximumPositionSelect = By.XPath("//div[@data-automation='TradingWithLeverageMaximumPosition']");
    private By _openPositionAutomaticallyCloseSelect = By.XPath("//div[@data-automation='OpenPositionAutomaticallyClose']");
    private By _whyTradeWithUsSelect = By.XPath("//div[@data-automation='WhyTradeWithUs']");
    private By _confirmationCheckbox = By.XPath("//input[@name='ForexBettingRiskDeclaration']");

    private By _notUsCitizenSwitch = By.XPath("//input[@name='NoUsaCitizenship']");
    private By _termsAndConditionsSwitch = By.XPath("//input[@name='TermsAndConditions']");
    private By _whatsAppUpdatesSwitch = By.XPath("//input[@name='WhatsAppConesnt']");
    //actions

}