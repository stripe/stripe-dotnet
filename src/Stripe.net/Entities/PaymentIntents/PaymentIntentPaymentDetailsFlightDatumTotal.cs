// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentIntentPaymentDetailsFlightDatumTotal : StripeEntity<PaymentIntentPaymentDetailsFlightDatumTotal>
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
        public PaymentIntentPaymentDetailsFlightDatumTotalDiscounts Discounts { get; set; }

        /// <summary>
        /// Additional charges for the flight.
        /// </summary>
        [JsonProperty("extra_charges")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("extra_charges")]
#endif
        public List<PaymentIntentPaymentDetailsFlightDatumTotalExtraCharge> ExtraCharges { get; set; }

        [JsonProperty("tax")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tax")]
#endif
        public PaymentIntentPaymentDetailsFlightDatumTotalTax Tax { get; set; }
    }
}
