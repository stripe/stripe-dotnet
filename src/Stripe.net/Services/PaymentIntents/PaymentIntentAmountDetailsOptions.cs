// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentAmountDetailsOptions : INestedOptions
    {
        /// <summary>
        /// The total discount applied on the transaction represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than 0.
        ///
        /// This field is mutually exclusive with the
        /// <c>amount_details[line_items][#][discount_amount]</c> field.
        /// </summary>
        [JsonProperty("discount_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discount_amount")]
#endif
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Set to <c>false</c> to return arithmetic validation errors in the response without
        /// failing the request. Use this when you want the operation to proceed regardless of
        /// arithmetic errors in the line item data.
        ///
        /// Omit or set to <c>true</c> to immediately return a 400 error when arithmetic validation
        /// fails. Use this for strict validation that prevents processing with line item data that
        /// has arithmetic inconsistencies.
        ///
        /// For card payments, Stripe doesn't send line item data if there's an arithmetic
        /// validation error to card networks.
        /// </summary>
        [JsonProperty("enforce_arithmetic_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("enforce_arithmetic_validation")]
#endif
        public bool? EnforceArithmeticValidation { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 200 line items.
        /// </summary>
        [JsonProperty("line_items")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("line_items")]
#endif
        public List<PaymentIntentAmountDetailsLineItemOptions> LineItems { get; set; }

        /// <summary>
        /// Contains information about the shipping portion of the amount.
        /// </summary>
        [JsonProperty("shipping")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("shipping")]
#endif
        public PaymentIntentAmountDetailsShippingOptions Shipping { get; set; }

        /// <summary>
        /// Contains information about the tax portion of the amount.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentAmountDetailsTaxOptions Tax { get; set; }
    }
}
