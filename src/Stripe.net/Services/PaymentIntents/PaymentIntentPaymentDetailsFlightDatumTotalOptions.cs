// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentIntentPaymentDetailsFlightDatumTotalOptions : INestedOptions
    {
        /// <summary>
        /// Total flight amount.
        /// </summary>
        [JsonProperty("amount")]
        [STJS.JsonPropertyName("amount")]
        public long? Amount { get; set; }

        /// <summary>
        /// Reason for credit.
        /// One of: <c>other</c>, <c>partial_ticket_refund</c>,
        /// <c>passenger_transport_ancillary_cancellation</c>,
        /// <c>ticket_and_ancillary_cancellation</c>, or <c>ticket_cancellation</c>.
        /// </summary>
        [JsonProperty("credit_reason")]
        [STJS.JsonPropertyName("credit_reason")]
        public string CreditReason { get; set; }

        /// <summary>
        /// Total currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        /// <summary>
        /// Discount details.
        /// </summary>
        [JsonProperty("discounts")]
        [STJS.JsonPropertyName("discounts")]
        public PaymentIntentPaymentDetailsFlightDatumTotalDiscountsOptions Discounts { get; set; }

        /// <summary>
        /// Additional charges.
        /// </summary>
        [JsonProperty("extra_charges")]
        [STJS.JsonPropertyName("extra_charges")]
        public List<PaymentIntentPaymentDetailsFlightDatumTotalExtraChargeOptions> ExtraCharges { get; set; }

        /// <summary>
        /// Tax breakdown.
        /// </summary>
        [JsonProperty("tax")]
        [STJS.JsonPropertyName("tax")]
        public PaymentIntentPaymentDetailsFlightDatumTotalTaxOptions Tax { get; set; }
    }
}
