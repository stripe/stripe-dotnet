namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class MapperTest : BaseStripeTest
    {
        [Fact]
        public void DeserializeISODates()
        {
            var json = GetResourceAsString("api_fixtures.customer_iso_dates.json");
            var customer = Mapper<Customer>.MapFromJson(json);

            Assert.Equal("2018-01-01T12:34:56-07:00", customer.Description);
            Assert.Equal("2018-02-02T12:34:56+02:00", customer.Metadata["some_iso_date"]);
            Assert.Equal("2018-03-03T12:34:56+08:30", customer.Subscriptions.Data[0].Metadata["another_iso_date"]);
            Assert.Equal("2018-04-04T12:34:56Z", ((Card)customer.DefaultSource).Metadata["yet_another_iso_date"]);
            Assert.Equal("2018-04-04T12:34:56Z", ((Card)customer.Sources.Data[0]).Metadata["yet_another_iso_date"]);
        }
    }
}
