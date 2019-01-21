namespace StripeTests
{
    using Newtonsoft.Json;
    using Stripe;
    using Xunit;

    public class ReviewTest : BaseStripeTest
    {
        public ReviewTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Deserialize()
        {
            string json = this.GetFixture("/v1/reviews/prv_123");
            var review = JsonConvert.DeserializeObject<Review>(json);
            Assert.NotNull(review);
            Assert.IsType<Review>(review);
            Assert.NotNull(review.Id);
            Assert.Equal("review", review.Object);
        }

        [Fact]
        public void DeserializeWithExpansions()
        {
            string[] expansions =
            {
              "charge",
              "payment_intent",
            };

            string json = this.GetFixture("/v1/reviews/prv_123", expansions);
            var review = JsonConvert.DeserializeObject<Review>(json);
            Assert.NotNull(review);
            Assert.IsType<Review>(review);
            Assert.NotNull(review.Id);
            Assert.Equal("review", review.Object);

            Assert.NotNull(review.Charge);
            Assert.Equal("charge", review.Charge.Object);

            Assert.NotNull(review.PaymentIntent);
            Assert.Equal("payment_intent", review.PaymentIntent.Object);
        }
    }
}
