﻿using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace BPCalculatorAcceptanceTests.PageObjects
{
    class BPCalculatorObjects
    {
        //The URL of the calculator to be opened in the browser
        private const string CalculatorUrl = "https://bloodpressurecalculator.azurewebsites.net/";

        //The Selenium web driver to automate the browser
        private readonly IWebDriver _webDriver;

        //The default wait time in seconds for wait.Until
        public const int DefaultWaitInSeconds = 5;

        public BPCalculatorObjects(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        public void goToWebsite()
        {
            _webDriver.Navigate().GoToUrl(CalculatorUrl);

        }

        //Finding elements by ID
        private IWebElement systolicElement => _webDriver.FindElement(By.CssSelector("input[id='BP_Systolic']"));
        private IWebElement diastolicElement => _webDriver.FindElement(By.CssSelector("input[id='BP_Diastolic']"));
        private IWebElement submitButtonElement => _webDriver.FindElement(By.CssSelector("input[value='Submit']"));
        private IWebElement resultElement => _webDriver.FindElement(By.CssSelector("label[id='results']"));
        private IWebElement ResetButtonElement => _webDriver.FindElement(By.Id("reset-button"));

        public void enterSystolicNumber(string number)
        {
            //Clear text box
            systolicElement.Clear();
            //Enter text
            systolicElement.SendKeys(number);
        }

        public void enterDiastolicNumber(string number)
        {
            //Clear text box
            diastolicElement.Clear();
            //Enter text
            diastolicElement.SendKeys(number);
        }

        public void clickSubmitButton()
        {
            //Click the add button
            submitButtonElement.Click();
        }

        public string getResults()
        {
            return resultElement.Text;
        }


        public void EnsureCalculatorIsOpenAndReset()
        {
            //Open the calculator page in the browser if not opened yet
            if (_webDriver.Url != CalculatorUrl)
            {
                _webDriver.Url = CalculatorUrl;
            }
            //Otherwise reset the calculator by clicking the reset button
            else
            {
                //Click the rest button
                ResetButtonElement.Click();

                //Wait until the result is empty again
                WaitForEmptyResult();
            }
        }

        public string WaitForNonEmptyResult()
        {
            //Wait for the result to be not empty
            return WaitUntil(
                () => resultElement.GetAttribute("value"),
                result => !string.IsNullOrEmpty(result));
        }

        public string WaitForEmptyResult()
        {
            //Wait for the result to be empty
            return WaitUntil(
                () => resultElement.GetAttribute("value"),
                result => result == string.Empty);
        }


        /// <summary>
        /// Helper method to wait until the expected result is available on the UI
        /// </summary>
        /// <typeparam name="T">The type of result to retrieve</typeparam>
        /// <param name="getResult">The function to poll the result from the UI</param>
        /// <param name="isResultAccepted">The function to decide if the polled result is accepted</param>
        /// <returns>An accepted result returned from the UI. If the UI does not return an accepted result within the timeout an exception is thrown.</returns>
        private T WaitUntil<T>(Func<T> getResult, Func<T, bool> isResultAccepted) where T : class
        {
            var wait = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(DefaultWaitInSeconds));
            return wait.Until(driver =>
            {
                var result = getResult();
                if (!isResultAccepted(result))
                    return default;

                return result;
            });

        }
    }
}