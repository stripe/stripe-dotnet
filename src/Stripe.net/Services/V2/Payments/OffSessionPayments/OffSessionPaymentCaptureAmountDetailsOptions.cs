// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class OffSessionPaymentCaptureAmountDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The amount the total transaction was discounted for.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Set to <c>false</c> to return arithmetic validation errors in the response without
        /// failing the request. Use this when you want the operation to proceed regardless of
        /// arithmetic errors in the line item data. Omit or set to <c>true</c> to immediately
        /// return a 400 error when arithmetic validation fails. Use this for strict validation that
        /// prevents processing with line item data that has arithmetic inconsistencies. For card
        /// payments, Stripe doesn't send line item data to card networks if there's an arithmetic
        /// validation error.
        /// </summary>
        [JsonProperty("enforce_arithmetic_validation")]
        [STJS.JsonPropertyName("enforce_arithmetic_validation")]
        public bool? EnforceArithmeticValidation { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the
        /// OffSessionPayment. There is a maximum of 10 line items.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OffSessionPaymentCaptureAmountDetailsLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Contains information about the shipping portion of the amount.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public OffSessionPaymentCaptureAmountDetailsShippingOptions Shipping { get; set; }

        /// <summary>
        /// Contains information about the tax portion of the amount.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public OffSessionPaymentCaptureAmountDetailsTaxOptions Tax { get; set; }
    }
}
