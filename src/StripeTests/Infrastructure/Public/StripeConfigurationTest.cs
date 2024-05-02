namespace StripeTests
{
    using System;
    using System.Net;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using Stripe;
    using Xunit;

    public class StripeConfigurationTest : BaseStripeTest
    {
        [Fact]
        public void StripeClient_Getter_CreatesNewStripeClientIfNullAndApiKeyIsSet()
        {
            var origApiKey = StripeConfiguration.ApiKey;
            var origClientId = StripeConfiguration.ClientId;

            try
            {
                StripeConfiguration.ApiKey = "sk_key_stripeconfiguration";
                StripeConfiguration.ClientId = "ca_stripeconfiguration";
                StripeConfiguration.StripeClient = null;

                var client = StripeConfiguration.StripeClient;
                Assert.NotNull(client);
                Assert.Equal(StripeConfiguration.ApiKey, client.ApiKey);
                Assert.Equal(StripeConfiguration.ClientId, client.ClientId);
            }
            finally
            {
                StripeConfiguration.ApiKey = origApiKey;
                StripeConfiguration.ClientId = origClientId;
            }
        }

        [Fact]
        public void StripeClient_Getter_CreatesNewStripeClientIfNullAndApiKeyIsNull()
        {
            var origApiKey = StripeConfiguration.ApiKey;

            try
            {
                StripeConfiguration.ApiKey = null;
                StripeConfiguration.StripeClient = null;

                var client = StripeConfiguration.StripeClient;
                Assert.NotNull(client);
                Assert.Null(client.ApiKey);
            }
            finally
            {
                StripeConfiguration.ApiKey = origApiKey;
            }
        }

        [Fact]
        public void StripeClient_Getter_ThrowsIfClientIsNullAndApiKeyIsEmpty()
        {
            var origApiKey = StripeConfiguration.ApiKey;

            try
            {
                StripeConfiguration.ApiKey = string.Empty;
                StripeConfiguration.StripeClient = null;

                var exception = Assert.Throws<StripeException>(() =>
                    StripeConfiguration.StripeClient);
                Assert.Contains("Your API key is invalid, as it is an empty string.", exception.Message);
            }
            finally
            {
                StripeConfiguration.ApiKey = origApiKey;
            }
        }

        [Fact]
        public void StripeClient_Getter_ThrowsIfClientIsNullAndApiKeyContainsWhitespace()
        {
            var origApiKey = StripeConfiguration.ApiKey;

            try
            {
                StripeConfiguration.ApiKey = "sk_stripeconfiguration\n";
                StripeConfiguration.StripeClient = null;

                var exception = Assert.Throws<StripeException>(() =>
                    StripeConfiguration.StripeClient);
                Assert.Contains("Your API key is invalid, as it contains whitespace.", exception.Message);
            }
            finally
            {
                StripeConfiguration.ApiKey = origApiKey;
            }
        }
    }
}
