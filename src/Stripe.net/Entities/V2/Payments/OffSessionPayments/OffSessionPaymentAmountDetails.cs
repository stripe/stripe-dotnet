// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OffSessionPaymentAmountDetails : StripeEntity<OffSessionPaymentAmountDetails>
    {
        /// <summary>
        /// The amount the total transaction was discounted for.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 100 line items.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<OffSessionPaymentAmountDetailsLineItem> LineItems { get; set; }

        /// <summary>
        /// Contains information about the shipping portion of the amount.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public OffSessionPaymentAmountDetailsShipping Shipping { get; set; }

        /// <summary>
        /// Contains information about the tax portion of the amount.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public OffSessionPaymentAmountDetailsTax Tax { get; set; }
    }
}
