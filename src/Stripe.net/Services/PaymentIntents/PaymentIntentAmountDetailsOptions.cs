// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentAmountDetailsOptions : INestedOptions, IHasSetTracking
    {
        private long? discountAmount;
        private List<PaymentIntentAmountDetailsLineItemOptions> lineItems;
        private PaymentIntentAmountDetailsShippingOptions shipping;
        private PaymentIntentAmountDetailsTaxOptions tax;

        [JsonIgnore]
        [STJS.JsonIgnore]
        internal SetTracker SetTracker { get; } = new SetTracker();

        /// <summary>
        /// The total discount applied on the transaction represented in the <a
        /// href="https://docs.stripe.com/currencies#zero-decimal">smallest currency unit</a>. An
        /// integer greater than 0.
        ///
        /// This field is mutually exclusive with the
        /// <c>amount_details[line_items][#][discount_amount]</c> field.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long? DiscountAmount
        {
            get => this.discountAmount;
            set
            {
                this.discountAmount = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Set to <c>false</c> to return arithmetic validation errors in the response without
        /// failing the request. Use this when you want the operation to proceed regardless of
        /// arithmetic errors in the line item data.
        ///
        /// Omit or set to <c>true</c> to immediately return a 400 error when arithmetic validation
        /// fails. Use this for strict validation that prevents processing with line item data that
        /// has arithmetic inconsistencies.
        ///
        /// For card payments, Stripe doesn't send line item data to card networks if there's an
        /// arithmetic validation error.
        /// </summary>
        [JsonProperty("enforce_arithmetic_validation")]
        [STJS.JsonPropertyName("enforce_arithmetic_validation")]
        public bool? EnforceArithmeticValidation { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 200 line items.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<PaymentIntentAmountDetailsLineItemOptions> LineItems
        {
            get => this.lineItems;
            set
            {
                this.lineItems = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Contains information about the shipping portion of the amount.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public PaymentIntentAmountDetailsShippingOptions Shipping
        {
            get => this.shipping;
            set
            {
                this.shipping = value;
                this.SetTracker.Track();
            }
        }

        /// <summary>
        /// Contains information about the tax portion of the amount.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentAmountDetailsTaxOptions Tax
        {
            get => this.tax;
            set
            {
                this.tax = value;
                this.SetTracker.Track();
            }
        }

        bool IHasSetTracking.IsPropertySet(string propertyName)
        {
            return this.SetTracker.IsSet(propertyName);
        }
    }
}
