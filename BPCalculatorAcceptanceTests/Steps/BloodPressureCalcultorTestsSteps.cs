using BPCalculatorAcceptanceTests.PageObjects;
using BPCalculatorAcceptanceTests.Drivers;
using TechTalk.SpecFlow;
using NUnit.Framework;

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


    }
}
