// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class SubscriptionScheduleCancelOptions : BaseOptions
    {
        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if a final invoice will be
        /// generated that contains any un-invoiced metered usage and new/pending proration invoice
        /// items. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("invoice_now")]
        [STJS.JsonPropertyName("invoice_now")]
        public bool? InvoiceNow { get; set; }

        /// <summary>
        /// If the subscription schedule is <c>active</c>, indicates if the cancellation should be
        /// prorated. Defaults to <c>true</c>.
        /// </summary>
        [JsonProperty("prorate")]
        [STJS.JsonPropertyName("prorate")]
        public bool? Prorate { get; set; }
    }
}
