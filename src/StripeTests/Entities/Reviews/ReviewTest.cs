namespace StripeTests
{
    using Stripe;
    using Xunit;

    public class ReviewTest : BaseStripeTest
    {
        [Fact]
        public void Deserialize()
        {
            string json = GetFixture("/v1/reviews/prv_123");
            var review = Mapper<Review>.MapFromJson(json);
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

            string json = GetFixture("/v1/reviews/prv_123", expansions);
            var review = Mapper<Review>.MapFromJson(json);
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
