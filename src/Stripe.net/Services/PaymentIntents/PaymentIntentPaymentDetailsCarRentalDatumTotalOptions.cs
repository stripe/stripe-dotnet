// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsCarRentalDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total amount in cents.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Currency of the amount.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Discount details for the rental.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public PaymentIntentPaymentDetailsCarRentalDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges for the rental.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<PaymentIntentPaymentDetailsCarRentalDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Rate per unit for the rental.
        /// </summary>
        [JsonProperty("rate_per_unit")]
        [STJS.JsonPropertyName("rate_per_unit")]
        public long? RatePerUnit { get; set; }

        /// <summary>
        /// Unit of measurement for the rate.
        /// One of: <c>days</c>, <c>kilometers</c>, <c>miles</c>, <c>months</c>, or <c>weeks</c>.
        /// </summary>
        [JsonProperty("rate_unit")]
        [STJS.JsonPropertyName("rate_unit")]
        public string RateUnit { get; set; }

        /// <summary>
        /// Tax breakdown for the rental.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentPaymentDetailsCarRentalDatumTotalTaxOptions Tax { get; set; }
    }
}
