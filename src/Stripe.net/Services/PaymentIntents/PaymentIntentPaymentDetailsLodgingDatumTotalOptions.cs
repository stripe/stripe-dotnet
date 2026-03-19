// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total price of the lodging reservation in cents.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Cash advances in cents.
        /// </summary>
        [JsonProperty("cash_advances")]
        [STJS.JsonPropertyName("cash_advances")]
        public long? CashAdvances { get; set; }

        /// <summary>
        /// Currency of the total amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Discount details for the lodging.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public PaymentIntentPaymentDetailsLodgingDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges for the lodging.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<PaymentIntentPaymentDetailsLodgingDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Prepaid amount in cents.
        /// </summary>
        [JsonProperty("prepaid_amount")]
        [STJS.JsonPropertyName("prepaid_amount")]
        public long? PrepaidAmount { get; set; }

        /// <summary>
        /// Tax breakdown for the lodging reservation.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentPaymentDetailsLodgingDatumTotalTaxOptions Tax { get; set; }
    }
}
