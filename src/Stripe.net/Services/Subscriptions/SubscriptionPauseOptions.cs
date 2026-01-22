// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SubscriptionPauseOptions : BaseOptions
    {
        /// <summary>
        /// Controls what to bill for when pausing the subscription.
        /// </summary>
        [JsonProperty("bill_for")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("bill_for")]
#endif
        public SubscriptionBillForOptions BillFor { get; set; }

        /// <summary>
        /// Determines how to handle debits and credits when pausing. The default is
        /// <c>pending_invoice_item</c>.
        /// One of: <c>invoice</c>, or <c>pending_invoice_item</c>.
        /// </summary>
        [JsonProperty("invoicing_behavior")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoicing_behavior")]
#endif
        public string InvoicingBehavior { get; set; }

        /// <summary>
        /// The type of pause to apply.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
