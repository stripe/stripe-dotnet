// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReceivedDebitInitiatingPaymentMethodDetailsFinancialAccount : StripeEntity<ReceivedDebitInitiatingPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// The FinancialAccount ID.
        /// </summary>
        [JsonProperty("id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("id")]
#endif

        public string Id { get; set; }

        /// <summary>
        /// The rails the ReceivedCredit was sent over. A FinancialAccount can only send funds over
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("network")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("network")]
#endif

        public string Network { get; set; }
    }
}
