namespace StripeTests
{
    using System.Text.Json;
    using Stripe;
    using Xunit;

    public class LineItemTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            var json = GetResourceAsString("api_fixtures.line_item.json");
            var lineItem = JsonSerializer.Deserialize<LineItem>(json);
            Assert.NotNull(lineItem);
            Assert.IsType<LineItem>(lineItem);
            Assert.Equal("item", lineItem.Object);
        }
    }
}
