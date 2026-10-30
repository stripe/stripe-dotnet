// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentMethodUsBankAccountExternalTokenOptions : INestedOptions
    {
        /// <summary>
        /// The Plaid processor token to use for this bank account.
        /// </summary>
        [JsonProperty("plaid_processor_token")]
        [STJS.JsonPropertyName("plaid_processor_token")]
        public string PlaidProcessorToken { get; set; }

        /// <summary>
        /// The type of external token.
        /// One of: <c>plaid_processor_token</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
