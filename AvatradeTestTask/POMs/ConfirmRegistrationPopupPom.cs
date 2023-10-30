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
    private By _countryOption(string countryName) => By.XPath($"//div[@role='option']//span[@class='country-name' and contains(text(), '{countryName}')]");
    private By _cityInput = By.XPath("//input[@name='City']");
    private By _streetNameInput = By.XPath("//input[@name='Street']");
    private By _buildingNumberInput = By.XPath("//input[@name='BuildingNumber']");
    private By _zipCodeInput = By.XPath("//input[@name='ZipCode']");
    private By _phoneNumberInput = By.XPath("//input[@name='Phone']");
    private By _continueFinishButton = By.XPath("//button[@type='submit']");
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
    public ConfirmRegistrationPopupPom FirstNameInputFill(string firstName)
    {
        SendKeys(_firstNameInput, firstName);
        return this;
    }

    public ConfirmRegistrationPopupPom LastNameInputFill(string lastName)
    {
        SendKeys(_lastNameInput, lastName);
        return this;
    }
    
    public ConfirmRegistrationPopupPom BirthdayInputFill(string birthday)
    {
        SendKeys(_birthdayInput, birthday);
        return this;
    }

    public ConfirmRegistrationPopupPom CountryInputFill(string country)
    {
        SendKeys(_countryInput, country);
        return this;
    }

    public ConfirmRegistrationPopupPom CountryOptionSelect(string country)
    {
        Click(_countryOption(country));
        return this;
    }
    public ConfirmRegistrationPopupPom CityInputFill(string city)
    {
        SendKeys(_cityInput, city);
        return this;
    }

    public ConfirmRegistrationPopupPom StreetNameInputFill(string streetName)
    {
        SendKeys(_streetNameInput, streetName);
        return this;
    }

    public ConfirmRegistrationPopupPom BuildingNumberInputFill(string buildingNumber)
    {
        SendKeys(_buildingNumberInput, buildingNumber);
        return this;
    }

    public ConfirmRegistrationPopupPom ZipCodeInputFill(string zipCode)
    {
        SendKeys(_zipCodeInput, zipCode);
        return this;
    }

    public ConfirmRegistrationPopupPom PhoneNumberInputFill(string phoneNumber)
    {
        SendKeys(_phoneNumberInput, phoneNumber);
        return this;
    }

    public ConfirmRegistrationPopupPom ContinueButtonClick()
    {
        Click(_continueFinishButton);
        return this; 
    }

    public ConfirmRegistrationPopupPom OccupationOrBusinessSelectClick()
    {
        Click(_occupationOrBusinessSelect);
        return this;
    }

    public ConfirmRegistrationPopupPom EmploymentStatusSelectClick()
    {
        Click(_employmentStatusSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom SourceOfTradeFundsSelectClick()
    {
        Click(_sourceOfTradeFundsSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom EstimatedAnnualIncomeSelectClick()
    {
        Click(_estimatedAnnualIncomeSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom SavingsAndInvestmentsSelectClick()
    {
        Click(_savingsAndInvestmentsSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom AmountIntendInvestingEveryYearSelectClick()
    {
        Click(_amountIntendInvestingEveryYearSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom RelevantExperienceYesButtonClick()
    {
        Click(_relevantExperienceYesButton);
        return this;
    }

    public ConfirmRegistrationPopupPom RelevantExperienceNoButtonClick()
    {
        Click(_relevantExperienceNoButton);
        return this; 
    }

    public ConfirmRegistrationPopupPom NumOfTimesTradingSelectClick()
    {
        Click(_numOfTimesTradingSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom WhatWasTheAverageSizeOfTradesSelectClick()
    {
        Click(_whatWasTheAverageSizeOfTradesSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom TradingWithLeverageAppliesSelectClick()
    {
        Click(_tradingWithLeverageAppliesSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom TradingWithLeverageMaximumPositionSelectClick()
    {
        Click(_tradingWithLeverageMaximumPositionSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom OpenPositionAutomaticallyCloseSelectClick()
    {
        Click(_openPositionAutomaticallyCloseSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom WhyTradeWithUsSelectClick()
    {
        Click(_whyTradeWithUsSelect);
        return this; 
    }

    public ConfirmRegistrationPopupPom ConfirmationCheckboxClick()
    {
        Click(_confirmationCheckbox);
        return this; 
    }

    public ConfirmRegistrationPopupPom NotUsCitizenSwitchClick()
    {
        Click(_notUsCitizenSwitch);
        return this; 
    }

    public ConfirmRegistrationPopupPom TermsAndConditionsSwitchClick()
    {
        Click(_termsAndConditionsSwitch);
        return this; 
    }

    public ConfirmRegistrationPopupPom WhatsAppUpdatesSwitchClick()
    { 
        Click(_whatsAppUpdatesSwitch);
        return this; 
    }

    public ConfirmRegistrationPopupPom SelectOption(string option)
    {
        Click(_selectOption(option));
        return this; 
    }
}