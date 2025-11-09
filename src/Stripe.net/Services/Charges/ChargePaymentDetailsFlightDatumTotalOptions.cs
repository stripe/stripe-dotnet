// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ChargePaymentDetailsFlightDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total flight amount.
        /// </summary>
        [JsonProperty("amount")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("amount")]
#endif
        public long? Amount { get; set; }

        /// <summary>
        /// Reason for credit.
        /// One of: <c>other</c>, <c>partial_ticket_refund</c>,
        /// <c>passenger_transport_ancillary_cancellation</c>,
        /// <c>ticket_and_ancillary_cancellation</c>, or <c>ticket_cancellation</c>.
        /// </summary>
        [JsonProperty("credit_reason")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("credit_reason")]
#endif
        public string CreditReason { get; set; }

        /// <summary>
        /// Total currency.
        /// </summary>
        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif
        public string Currency { get; set; }

        /// <summary>
        /// Discount details.
        /// </summary>
        [JsonProperty("discounts")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("discounts")]
#endif
        public ChargePaymentDetailsFlightDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<ChargePaymentDetailsFlightDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Tax breakdown.
        /// </summary>
        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public ChargePaymentDetailsFlightDatumTotalTaxOptions Tax { get; set; }
    }
}
