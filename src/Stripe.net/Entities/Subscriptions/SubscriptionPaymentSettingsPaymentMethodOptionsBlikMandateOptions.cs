// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions : StripeEntity<SubscriptionPaymentSettingsPaymentMethodOptionsBlikMandateOptions>
    {
        /// <summary>
        /// Date when the mandate expires and no further payments will be charged. If not provided,
        /// the mandate will be set to be indefinite.
        /// </summary>
        [JsonProperty("expires_after")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("expires_after")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime? ExpiresAfter { get; set; }
    }
}
