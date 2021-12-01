using BPCalculatorAcceptanceTests.Drivers;
using BPCalculatorAcceptanceTests.PageObjects;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace BPCalculatorAcceptanceTests.Steps
{
    [Binding]
    public class BloodPressureCalcultorTestsSteps
    {

        private readonly BPCalculatorObjects _calculatorPageObject;

        public BloodPressureCalcultorTestsSteps(browserDrivers browserDriver)
        {
            _calculatorPageObject = new BPCalculatorObjects(browserDriver.Current);
        }

        [Given(@"is on the Blood Pressure Calcultor Page")]
        public void GivenIsOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.goToWebsite();
        }

        [Given(@"the user enters (.*) in the Systolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserEntersInTheSystolicFieldOnTheBloodPressureCalcultorPage(string systolic)
        {
            _calculatorPageObject.enterSystolicNumber(systolic);
        }

        [Given(@"the user clears the Systolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserClearsTheSystolicFieldOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.clearSystolicNumber();
        }

        [Given(@"the user clears the Diastolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserClearsTheDiastolicFieldOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.clearDiastolicNumber();
        }



        [Given(@"the user enters (.*) in the Diastolic field on the Blood Pressure Calcultor Page")]
        public void GivenTheUserEntersInTheDiastolicFieldOnTheBloodPressureCalcultorPage(string diastolic)
        {
            _calculatorPageObject.enterDiastolicNumber(diastolic);
        }

        [When(@"the clicks on the submit button on the Blood Pressure Calcultor Page")]
        public void WhenTheClicksOnTheSubmitButtonOnTheBloodPressureCalcultorPage()
        {
            _calculatorPageObject.clickSubmitButton();
        }

        [Then(@"the result (.*) will be diplayed on the Blood Pressure Calcultor Page")]
        public void ThenTheResultLowBloodPressureWillBeDiplayedOnTheBloodPressureCalcultorPage(string expectedValue)
        {
            string actualValue = _calculatorPageObject.getResults();
            Assert.AreEqual(actualValue, expectedValue);
        }



        [Then(@"Invalid (.*) Value message is diplayed on the Blood Pressure Calcultor Page")]
        public void ThenInvalidSystolicValueMessageIsDiplayedOnTheBloodPressureCalcultorPage(string expectedValue)
        {
            string actualValue = _calculatorPageObject.getInvalidMessage(expectedValue);
            Assert.AreEqual(actualValue, "Invalid " + expectedValue + " Value");
        }

        [Then(@"'(.*)' field is required message is diplayed on the Blood Pressure Calcultor Page")]
        public void ThenFieldIsRequiredMessageIsDiplayedOnTheBloodPressureCalcultorPage(string expectedValue)
        {
            string actualValue = _calculatorPageObject.getInvalidMessage(expectedValue);
            Assert.AreEqual(actualValue, "The " + expectedValue + " field is required.");
        }

        [Then(@"Please enter a valid number message is diplayed under the '(.*)' field textbox on the Blood Pressure Calcultor Page")]
        public void ThenPleaseEnterAValidNumberMessageIsDiplayedUnderTheFieldTextboxOnTheBloodPressureCalcultorPage(string expectedValue)
        {
            string actualValue = _calculatorPageObject.getInvalidMessage(expectedValue);
            Assert.AreEqual("Please enter a valid number." , actualValue);
        }

        [Then(@"Systolic must be greater than Diastolic message is diplayed on the Blood Pressure Calcultor Page")]
        public void ThenSystolicMustBeGreaterThanDiastolicMessageIsDiplayedOnTheBloodPressureCalcultorPage()
        {
            string actualValue = _calculatorPageObject.getWarningMessage();
            Assert.AreEqual("Systolic must be greater than Diastolic", actualValue);
        }

    }
}
