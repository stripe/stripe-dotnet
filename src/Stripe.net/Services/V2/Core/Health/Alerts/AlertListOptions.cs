// File generated from our OpenAPI spec
namespace Stripe.V2.Core.Health
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AlertListOptions : V2.ListOptions
    {
        /// <summary>
        /// Filter for alerts created at the specified timestamp.
        /// </summary>
        [JsonProperty("created")]
        [STJS.JsonPropertyName("created")]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Filter for alerts created after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gt")]
        [STJS.JsonPropertyName("created_gt")]
        public DateTime? CreatedGt { get; set; }

        /// <summary>
        /// Filter for alerts created on or after the specified timestamp.
        /// </summary>
        [JsonProperty("created_gte")]
        [STJS.JsonPropertyName("created_gte")]
        public DateTime? CreatedGte { get; set; }

        /// <summary>
        /// Filter for alerts created before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lt")]
        [STJS.JsonPropertyName("created_lt")]
        public DateTime? CreatedLt { get; set; }

        /// <summary>
        /// Filter for alerts created on or before the specified timestamp.
        /// </summary>
        [JsonProperty("created_lte")]
        [STJS.JsonPropertyName("created_lte")]
        public DateTime? CreatedLte { get; set; }

        /// <summary>
        /// Filter by alert severity.
        /// One of: <c>critical</c>, or <c>non_critical</c>.
        /// </summary>
        [JsonProperty("severity")]
        [STJS.JsonPropertyName("severity")]
        public string Severity { get; set; }

        /// <summary>
        /// Filter by alert status.
        /// One of: <c>open</c>, or <c>resolved</c>.
        /// </summary>
        [JsonProperty("status")]
        [STJS.JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Filter by alert types.
        /// One of: <c>api_error</c>, <c>api_latency</c>, <c>authorization_rate_drop</c>,
        /// <c>elements_error</c>, <c>event_generation_failure</c>, <c>fraud_rate</c>,
        /// <c>invoice_count_dropped</c>, <c>issuing_authorization_request_errors</c>,
        /// <c>issuing_authorization_request_timeout</c>, <c>meter_event_summaries_delayed</c>,
        /// <c>metronome_notification_latency</c>, <c>payment_method_error</c>,
        /// <c>sepa_debit_delayed</c>, <c>traffic_volume_drop</c>, or <c>webhook_latency</c>.
        /// </summary>
        [JsonProperty("types")]
        [STJS.JsonPropertyName("types")]
        public List<string> Types { get; set; }
    }
}
