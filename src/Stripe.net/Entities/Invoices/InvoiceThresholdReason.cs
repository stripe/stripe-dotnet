// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceThresholdReason : StripeEntity<InvoiceThresholdReason>
    {
        /// <summary>
        /// The total invoice amount threshold boundary if it triggered the threshold invoice.
        /// </summary>
        [JsonProperty("amount_gte")]
        [STJS.JsonPropertyName("amount_gte")]
        public long? AmountGte { get; set; }

        /// <summary>
        /// Indicates which line items triggered a threshold invoice.
        /// </summary>
        [JsonProperty("item_reasons")]
        [STJS.JsonPropertyName("item_reasons")]
        public List<InvoiceThresholdReasonItemReason> ItemReasons { get; set; }
    }
}
