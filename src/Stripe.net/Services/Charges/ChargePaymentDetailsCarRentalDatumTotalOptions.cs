// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsCarRentalDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total amount in cents.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Currency of the amount.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Discount details for the rental.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public ChargePaymentDetailsCarRentalDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges for the rental.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<ChargePaymentDetailsCarRentalDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Rate per unit for the rental.
        /// </summary>
        [JsonProperty("rate_per_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_per_unit")]
#endif
        public long? RatePerUnit { get; set; }

        /// <summary>
        /// Unit of measurement for the rate.
        /// One of: <c>days</c>, <c>kilometers</c>, <c>miles</c>, <c>months</c>, or <c>weeks</c>.
        /// </summary>
        [JsonProperty("rate_unit")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("rate_unit")]
#endif
        public string RateUnit { get; set; }

        /// <summary>
        /// Tax breakdown for the rental.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public ChargePaymentDetailsCarRentalDatumTotalTaxOptions Tax { get; set; }
    }
}
