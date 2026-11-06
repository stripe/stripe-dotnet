namespace StripeTests
{
    using System.Net;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text.Json;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class StripeExceptionTest : BaseStripeTest
    {
        public StripeExceptionTest(StripeMockFixture stripeMockFixture)
            : base(stripeMockFixture)
        {
        }

        [Fact]
        public void Message_PrependsRequestId_WhenResponseHasRequestId()
        {
            var response = new StripeResponse(HttpStatusCode.PaymentRequired, BuildHeaders("req_123"), "{}");
            var exception = new StripeException("card declined") { StripeResponse = response };

            Assert.Equal("[req_123] card declined", exception.Message);
            Assert.Contains("[req_123] card declined", exception.ToString());
        }

        [Fact]
        public void Message_IsUnchanged_WhenResponseHasNoRequestId()
        {
            var response = new StripeResponse(HttpStatusCode.PaymentRequired, null, "{}");
            var exception = new StripeException("card declined") { StripeResponse = response };

            Assert.Equal("card declined", exception.Message);
        }

        [Fact]
        public void Message_IsUnchanged_WhenThereIsNoResponse()
        {
            var exception = new StripeException("card declined");

            Assert.Equal("card declined", exception.Message);
        }

        [Fact]
        public void Message_DoesNotDuplicatePrefix_OnRepeatedReads()
        {
            var response = new StripeResponse(HttpStatusCode.PaymentRequired, BuildHeaders("req_123"), "{}");
            var exception = new StripeException("card declined") { StripeResponse = response };

            Assert.Equal(exception.Message, exception.Message);
            Assert.Equal("[req_123] card declined", exception.Message);
        }

        [Fact]
        public void Message_StructuredErrorText_IsUnaffected()
        {
            var httpStatusCode = HttpStatusCode.PaymentRequired;
            var stripeError = new StripeError { Type = "card_error", Message = "card declined" };
            var response = new StripeResponse(httpStatusCode, BuildHeaders("req_123"), "{}");
            var exception = new StripeException(httpStatusCode, stripeError) { StripeResponse = response };

            Assert.Equal("[req_123] card declined", exception.Message);
            Assert.Equal("card declined", exception.StripeError.Message);
        }

        private static HttpResponseHeaders BuildHeaders(string requestId)
        {
            var message = new HttpResponseMessage();
            message.Headers.Add("Request-Id", requestId);
            return message.Headers;
        }

        [Fact]
        public async Task SetsStripeResponse()
        {
            // This test assumes that `POST /v1/payment_intents` has at least one required param,
            // and so will throw an exception if we provide zero params.
            var exception = await Assert.ThrowsAsync<StripeException>(async () =>
            {
                await new PaymentIntentService(this.StripeClient)
                    .CreateAsync(new PaymentIntentCreateOptions());
            });

            Assert.NotNull(exception);
            Assert.NotNull(exception.StripeError);
            Assert.NotNull(exception.StripeError.StripeResponse);
        }

        [Fact]
        public void DeserializesNetworkAdviceCode()
        {
            var json = "{\"type\": \"card_error\", \"network_advice_code\": \"02\"}";
            var error = JsonSerializer.Deserialize<StripeError>(json);
            Assert.Equal("02", error.NetworkAdviceCode);
        }

        [Fact]
        public void DeserializesPaymentIntent()
        {
            var json = "{\"type\": \"card_error\", \"payment_intent\": {\"id\": \"pi_123\", \"object\": \"payment_intent\", \"amount\": 1000}}";
            var error = JsonSerializer.Deserialize<StripeError>(json);
            Assert.NotNull(error.PaymentIntent);
            Assert.Equal("pi_123", error.PaymentIntent.Id);
            Assert.Equal(1000, error.PaymentIntent.Amount);
        }
    }
}
