namespace SpecFlowCalculator.Specs.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator calculator = new Calculator();
        private int res;

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            calculator.SecondNumber = number;
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            res = calculator.Add();
        }

        [When("the two numbers are subtracted")]
        public void WhenTheTwoNumbersAreSubtracted()
        {
            res = calculator.Subtract();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            res.Should().Be(result);
        }
    }
}