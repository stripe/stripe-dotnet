// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordGuaranteedOptions : INestedOptions
    {
        /// <summary>
        /// When the reported payment was guaranteed. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("guaranteed_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("guaranteed_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? GuaranteedAt { get; set; }

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
        public PaymentRecordGuaranteedProcessorDetailsOptions ProcessorDetails { get; set; }
    }
}
