// File generated from our OpenAPI spec
namespace Stripe.V2.Payments
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class OffSessionPaymentAmountDetails : StripeEntity<OffSessionPaymentAmountDetails>
    {
        /// <summary>
        /// The amount the total transaction was discounted for.
        /// </summary>
        [JsonProperty("discount_amount")]
        [STJS.JsonPropertyName("discount_amount")]
        public long? DiscountAmount { get; set; }

        /// <summary>
        /// Contains information about the error that occurred when validating the current amount
        /// details. This field populates when the amount details has a validation error that wasn't
        /// enforced because the <a
        /// href="https://docs.corp.stripe.com/api/payment_intents/create#create_payment_intent-amount_details-enforce_arithmetic_validation">enforce_arithmetic_validation</a>
        /// parameter was set to <c>false</c>.
        /// </summary>
        [JsonProperty("error")]
        [STJS.JsonPropertyName("error")]
        public OffSessionPaymentAmountDetailsError Error { get; set; }

        /// <summary>
        /// A list of line items, each containing information about a product in the PaymentIntent.
        /// There is a maximum of 100 line items.
        /// </summary>
        [JsonProperty("line_items")]
        [STJS.JsonPropertyName("line_items")]
        public List<OffSessionPaymentAmountDetailsLineItem> LineItems { get; set; }

        /// <summary>
        /// Contains information about the shipping portion of the amount.
        /// </summary>
        [JsonProperty("shipping")]
        [STJS.JsonPropertyName("shipping")]
        public OffSessionPaymentAmountDetailsShipping Shipping { get; set; }

        /// <summary>
        /// Contains information about the tax portion of the amount.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public OffSessionPaymentAmountDetailsTax Tax { get; set; }
    }
}
