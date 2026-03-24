// File generated from our OpenAPI spec
namespace Stripe.Treasury
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount : StripeEntity<ReceivedCreditInitiatingPaymentMethodDetailsFinancialAccount>, IHasId
    {
        /// <summary>
        /// The FinancialAccount ID.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// The rails the ReceivedCredit was sent over. A FinancialAccount can only send funds over
        /// <c>stripe</c>.
        /// </summary>
        [JsonProperty("network")]
        [STJS.JsonPropertyName("network")]
        public string Network { get; set; }
    }
}
