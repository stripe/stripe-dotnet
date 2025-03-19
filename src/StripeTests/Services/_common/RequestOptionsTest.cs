namespace StripeTests
{
    using System;
    using Stripe;
    using Stripe.Infrastructure.FormEncoding;
    using Xunit;

    public class RequestOptionsTest : BaseStripeTest
    {
        [Fact]
        public void WithClientOptionsSetsApiKey()
        {
            var clientOptions = new StripeClientOptions
            {
                ApiKey = "12345",
            };

            // Should copy when request option is empty
            var options = new RequestOptions();
            var newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(clientOptions.ApiKey, newOptions.ApiKey);

            // Should NOT copy when request option is set
            options = new RequestOptions() { ApiKey = "23456" };
            newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(options.ApiKey, newOptions.ApiKey);
        }

        [Fact]

        public void WithClientOptionsSetsStripeContext()
        {
            var clientOptions = new StripeClientOptions
            {
                StripeContext = "ctx_12345",
            };

            // Should copy when request option is empty
            var options = new RequestOptions();
            var newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(clientOptions.StripeContext, newOptions.StripeContext);

            // Should NOT copy when request option is set
            options = new RequestOptions() { StripeContext = "ctx_23456" };
            newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(options.StripeContext, newOptions.StripeContext);
        }

        [Fact]
        public void WithClientOptionsSetsStripeAccount()
        {
            var clientOptions = new StripeClientOptions
            {
                StripeAccount = "acct_12345",
            };

            // Should copy when request option is empty
            var options = new RequestOptions();
            var newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(clientOptions.StripeAccount, newOptions.StripeAccount);

            // Should NOT copy when request option is set
            options = new RequestOptions() { StripeAccount = "acct_23456" };
            newOptions = options.WithClientOptions(clientOptions);
            Assert.Equal(options.StripeAccount, newOptions.StripeAccount);
        }
    }
}
