namespace StripeTests
{
    using System.Collections.Generic;
    using System.Net;
    using System.Net.Http.Headers;
    using Stripe;
    using Xunit;

    public class StripeResponseTest : BaseStripeTest
    {
        /* Most of StripeResponse's methods are helpers for accessing headers. Unfortunately,
         * HttpResponseHeaders is a sealed class with no public constructor, which makes it
         * ~impossible to write unit tests for StripeResponse. This is why we rely on real
         * requests and fetch StripeResponse instances attached to resources.
         */

        [Fact]
        public void Date()
        {
            var response = new AccountService().GetSelf().StripeResponse;

            Assert.NotNull(response.Date);
        }

        [Fact]
        public void IdempotencyKey_Present()
        {
            var requestOptions = new RequestOptions { IdempotencyKey = "idempotency_key" };
            var response = new AccountService().GetSelf(requestOptions).StripeResponse;

            Assert.Equal("idempotency_key", response.IdempotencyKey);
        }

        [Fact]
        public void IdempotencyKey_Absent()
        {
            var response = new AccountService().GetSelf().StripeResponse;

            Assert.Null(response.IdempotencyKey);
        }

        [Fact]
        public void RequestId()
        {
            var response = new AccountService().GetSelf().StripeResponse;

            Assert.NotNull(response.RequestId);
        }
    }
}
