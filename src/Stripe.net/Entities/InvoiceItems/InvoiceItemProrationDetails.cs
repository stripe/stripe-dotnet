// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class InvoiceItemProrationDetails : StripeEntity<InvoiceItemProrationDetails>
    {
        /// <summary>
        /// Discount amounts applied when the proration was created.
        /// </summary>
        [JsonProperty("discount_amounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amounts")]
#endif
        public List<InvoiceItemProrationDetailsDiscountAmount> DiscountAmounts { get; set; }
    }
}
