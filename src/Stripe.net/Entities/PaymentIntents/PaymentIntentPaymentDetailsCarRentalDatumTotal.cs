// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumTotal : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumTotal>
    {
        /// <summary>
        /// Total amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// Currency for the total amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public PaymentIntentPaymentDetailsCarRentalDatumTotalDiscounts Discounts { get; set; }

        /// <summary>
        /// Additional charges for the rental.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<PaymentIntentPaymentDetailsCarRentalDatumTotalExtraCharge> ExtraCharges { get; set; }

        /// <summary>
        /// Rate per unit.
        /// </summary>
        [JsonProperty("rate_per_unit")]
        [STJS.JsonPropertyName("rate_per_unit")]
        public long RatePerUnit { get; set; }

        /// <summary>
        /// Unit for the rate.
        /// One of: <c>kilometers</c>, or <c>miles</c>.
        /// </summary>
        [JsonProperty("rate_unit")]
        [STJS.JsonPropertyName("rate_unit")]
        public string RateUnit { get; set; }

        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentPaymentDetailsCarRentalDatumTotalTax Tax { get; set; }
    }
}
