// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsLodgingDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total price of the lodging reservation in cents.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Cash advances in cents.
        /// </summary>
        [JsonProperty("cash_advances")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cash_advances")]
#endif
        public long? CashAdvances { get; set; }

        /// <summary>
        /// Currency of the total amount.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Discount details for the lodging.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public ChargePaymentDetailsLodgingDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges for the lodging.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<ChargePaymentDetailsLodgingDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Prepaid amount in cents.
        /// </summary>
        [JsonProperty("prepaid_amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("prepaid_amount")]
#endif
        public long? PrepaidAmount { get; set; }

        /// <summary>
        /// Tax breakdown for the lodging reservation.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public ChargePaymentDetailsLodgingDatumTotalTaxOptions Tax { get; set; }
    }
}
