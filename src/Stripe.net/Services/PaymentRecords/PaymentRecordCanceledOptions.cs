// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordCanceledOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment was canceled. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("canceled_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("canceled_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? CanceledAt { get; set; }

        /// <summary>
        /// Payment evaluations associated with this reported payment.
        /// </summary>
        [JsonProperty("payment_evaluations")]
        [STJS.JsonPropertyName("payment_evaluations")]
        public List<string> PaymentEvaluations { get; set; }

        /// <summary>
        /// The reason the payment attempt was canceled.
        /// One of: <c>blocked_for_fraud</c>, or <c>merchant_canceled</c>.
        ///
        /// This enum can grow over time; additional values may be added in the future.
        /// </summary>
        [JsonProperty("reason")]
        [STJS.JsonPropertyName("reason")]
        public string Reason { get; set; }
    }
}
