// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentIntentAdvancedFeatureDetails : StripeEntity<PaymentIntentAdvancedFeatureDetails>
    {
        /// <summary>
        /// Timestamp at which the authorization will expire if not captured.
        /// </summary>
        [JsonProperty("capture_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("capture_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime CaptureBefore { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("decremental_authorization")]
        [STJS.JsonPropertyName("decremental_authorization")]
        public PaymentIntentAdvancedFeatureDetailsDecrementalAuthorization DecrementalAuthorization { get; set; }

        [JsonProperty("incremental_authorization")]
        [STJS.JsonPropertyName("incremental_authorization")]
        public PaymentIntentAdvancedFeatureDetailsIncrementalAuthorization IncrementalAuthorization { get; set; }

        [JsonProperty("multicapture")]
        [STJS.JsonPropertyName("multicapture")]
        public PaymentIntentAdvancedFeatureDetailsMulticapture Multicapture { get; set; }

        [JsonProperty("overcapture")]
        [STJS.JsonPropertyName("overcapture")]
        public PaymentIntentAdvancedFeatureDetailsOvercapture Overcapture { get; set; }

        [JsonProperty("reauthorization")]
        [STJS.JsonPropertyName("reauthorization")]
        public PaymentIntentAdvancedFeatureDetailsReauthorization Reauthorization { get; set; }

        /// <summary>
        /// Timestamp at which the reauthorization window closes.
        /// </summary>
        [JsonProperty("reauthorize_before")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("reauthorize_before")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ReauthorizeBefore { get; set; }
    }
}
