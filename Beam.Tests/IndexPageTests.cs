using System;
using Xunit;
using Bunit;
using Bunit.TestDoubles;

namespace Beam.Tests
{
    /// <summary>
    /// These tests are written entirely in C#.
    /// Learn more at https://bunit.egilhansen.com/docs/getting-started/
    /// </summary>
    public class IndexPageTests : TestContext
    {
        [Fact]
        public void CounterStartsAtZero()
        {
            // Arrange
            var cut = RenderComponent<Beam.Client.Pages.Index>();

            // Assert that content of the paragraph shows counter at zero
            Assert.Contains("Select a Frequency", cut.Markup);
            cut.MarkupMatches(@"<h2 diff:ignore> </h2>
                                <p diff:ignore> </p>");
        }

        [Fact]
        public void ClickingButtonIncrementsCounter()
        {
            // Arrange
            var cut = RenderComponent<Counter>();

            // Act - click button to increment counter
            cut.Find("button").Click();

            // Assert that the counter was incremented
            cut.Find("p").MarkupMatches("<p>Current count: 1</p>");
        }
    }
}
