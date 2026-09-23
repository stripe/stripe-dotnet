namespace StripeTests
{
    using System.Text.Json;
    using Stripe.V2;
    using Xunit;

    public class V2AddressOptionsTest
    {
        [Fact]
        public void SerializesStandardFieldsAndTown()
        {
            var options = new AddressOptions
            {
                Country = "US",
                Line1 = "123 Main Street",
                Town = "Brooklyn",
            };

            var json = JsonSerializer.Serialize(options);

            Assert.Contains("\"country\":\"US\"", json);
            Assert.Contains("\"line1\":\"123 Main Street\"", json);
            Assert.Contains("\"town\":\"Brooklyn\"", json);
        }
    }
}
