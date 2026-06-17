// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordFailedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment failed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("failed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("failed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? FailedAt { get; set; }

        /// <summary>
        /// The failure code for this payment attempt. Must be one of
        /// <c>payment_method_customer_decline</c> or
        /// <c>payment_method_provider_unknown_outcome</c>.
        /// One of: <c>payment_method_customer_decline</c>, or
        /// <c>payment_method_provider_unknown_outcome</c>.
        /// </summary>
        [JsonProperty("failure_code")]
        [STJS.JsonPropertyName("failure_code")]
        public string FailureCode { get; set; }

        /// <summary>
        /// Provides the reason for the refund failure. Possible values are:
        /// <c>lost_or_stolen_card</c>, <c>expired_or_canceled_card</c>,
        /// <c>charge_for_pending_refund_disputed</c>, <c>insufficient_funds</c>, <c>declined</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// One of: <c>charge_for_pending_refund_disputed</c>, <c>declined</c>,
        /// <c>expired_or_canceled_card</c>, <c>insufficient_funds</c>, <c>lost_or_stolen_card</c>,
        /// <c>merchant_request</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("failure_reason")]
        [STJS.JsonPropertyName("failure_reason")]
        public string FailureReason { get; set; }

        /// <summary>
        /// Payment evaluations associated with this reported payment.
        /// </summary>
        [JsonProperty("payment_evaluations")]
        [STJS.JsonPropertyName("payment_evaluations")]
        public List<string> PaymentEvaluations { get; set; }

        /// <summary>
        /// Processor information for this payment.
        /// </summary>
        [JsonProperty("processor_details")]
        [STJS.JsonPropertyName("processor_details")]
        public PaymentRecordFailedProcessorDetailsOptions ProcessorDetails { get; set; }
    }
}
