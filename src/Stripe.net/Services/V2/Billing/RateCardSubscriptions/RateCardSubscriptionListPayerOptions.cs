// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class RateCardSubscriptionListPayerOptions : INestedOptions
    {
        /// <summary>
        /// The ID of the Customer object. If provided, only the Rate Card Subscriptions that are
        /// subscribed on the Billing Cadences with the specified payer will be returned.
        /// </summary>
        [JsonProperty("customer")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customer")]
#endif
        public string Customer { get; set; }

        /// <summary>
        /// A string identifying the type of the payer. Currently the only supported value is
        /// <c>customer</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
