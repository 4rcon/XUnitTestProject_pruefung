using System;
using TechTalk.SpecFlow;

namespace XUnitTestProject_pruefung
{
    [Binding]
    public class UnknownSteps
    {
        [Given(@"the object Math\.pi")]
        public double GivenTheObjectMath_Pi()
        {
            return Math.PI;
        }
        
        [Given(@"(.*) and object Math")]
        public void GivenAndObjectMath(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"calling pi function")]
        public void WhenCallingPiFunction()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"passing (.*)")]
        public void WhenPassing(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be exaclty pi")]
        public void ThenTheResultShouldBeExacltyPi()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"should return Sin\(number\)")]
        public void ThenShouldReturnSinNumber()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
