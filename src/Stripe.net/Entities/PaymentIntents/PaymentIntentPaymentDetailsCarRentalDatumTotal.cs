// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsCarRentalDatumTotal : StripeEntity<PaymentIntentPaymentDetailsCarRentalDatumTotal>
    {
        /// <summary>
        /// Total amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long Amount { get; set; }

        /// <summary>
        /// Currency for the total amount.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumTotalDiscounts Discounts { get; set; }

        /// <summary>
        /// Additional charges for the rental.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<PaymentIntentPaymentDetailsCarRentalDatumTotalExtraCharge> ExtraCharges { get; set; }

        /// <summary>
        /// Rate per unit.
        /// </summary>
        [JsonProperty("rate_per_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_per_unit")]
#endif
        public long RatePerUnit { get; set; }

        /// <summary>
        /// Unit for the rate.
        /// One of: <c>kilometers</c>, or <c>miles</c>.
        /// </summary>
        [JsonProperty("rate_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_unit")]
#endif
        public string RateUnit { get; set; }

        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentPaymentDetailsCarRentalDatumTotalTax Tax { get; set; }
    }
}
