namespace StripeTests.Terminal
{
    using Newtonsoft.Json;
    using Stripe.Terminal;
    using Xunit;

    public class ReaderTest : BaseStripeTest
    {
        public ReaderTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/terminal/readers/ds_123");
            var reader = JsonConvert.DeserializeObject<Reader>(json);
            Assert.NotNull(reader);
            Assert.IsType<Reader>(reader);
            Assert.NotNull(reader.Id);
            Assert.Equal("terminal.reader", reader.Object);
        }
    }
}
