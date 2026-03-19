// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class PaymentRecordReportPaymentAttemptFailedOptions : BaseOptions, IHasMetadata
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
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("failure_code")]
#endif
        public string FailureCode { get; set; }

        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }
    }
}
