// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsLodgingDatumTotal : StripeEntity<PaymentIntentPaymentDetailsLodgingDatumTotal>
    {
        /// <summary>
        /// Total price of the lodging reservation in cents.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Cash advances in cents.
        /// </summary>
        [JsonProperty("cash_advances")]
        [STJS.JsonPropertyName("cash_advances")]
        public long CashAdvances { get; set; }

        /// <summary>
        /// Currency of the total amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public PaymentIntentPaymentDetailsLodgingDatumTotalDiscounts Discounts { get; set; }

        /// <summary>
        /// Additional charges for the lodging.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<PaymentIntentPaymentDetailsLodgingDatumTotalExtraCharge> ExtraCharges { get; set; }

        /// <summary>
        /// Prepaid amount in cents.
        /// </summary>
        [JsonProperty("prepaid_amount")]
        [STJS.JsonPropertyName("prepaid_amount")]
        public long PrepaidAmount { get; set; }

        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentPaymentDetailsLodgingDatumTotalTax Tax { get; set; }
    }
}
