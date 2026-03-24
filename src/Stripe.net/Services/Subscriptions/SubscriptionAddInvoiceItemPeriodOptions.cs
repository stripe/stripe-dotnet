// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionAddInvoiceItemPeriodOptions : INestedOptions
    {
        /// <summary>
        /// End of the invoice item period.
        /// </summary>
        [JsonProperty("end")]
        [STJS.JsonPropertyName("end")]
        public SubscriptionAddInvoiceItemPeriodEndOptions End { get; set; }

        /// <summary>
        /// Start of the invoice item period.
        /// </summary>
        [JsonProperty("start")]
        [STJS.JsonPropertyName("start")]
        public SubscriptionAddInvoiceItemPeriodStartOptions Start { get; set; }
    }
}
