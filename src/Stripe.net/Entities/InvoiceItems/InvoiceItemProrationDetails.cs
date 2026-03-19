// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class InvoiceItemProrationDetails : StripeEntity<InvoiceItemProrationDetails>
    {
        /// <summary>
        /// Discount amounts applied when the proration was created.
        /// </summary>
        [JsonProperty("discount_amounts")]
        [STJS.JsonPropertyName("discount_amounts")]
        public List<InvoiceItemProrationDetailsDiscountAmount> DiscountAmounts { get; set; }
    }
}
