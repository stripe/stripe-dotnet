// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceAppliedCreditMemos : StripeEntity<InvoiceAppliedCreditMemos>
    {
        /// <summary>
        /// The Credit Memos with credit currently applied to this invoice, with one entry per
        /// Credit Memo. An invoice can have credit applied from at most 10 Credit Memos, so the
        /// list is returned in full.
        /// </summary>
        [JsonProperty("data")]
        [STJS.JsonPropertyName("data")]
        public List<InvoiceAppliedCreditMemosData> Data { get; set; }
    }
}
