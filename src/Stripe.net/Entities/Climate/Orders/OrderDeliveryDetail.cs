// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OrderDeliveryDetail : StripeEntity<OrderDeliveryDetail>
    {
        /// <summary>
        /// Time at which the delivery occurred. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("delivered_at")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime DeliveredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Specific location of this delivery.
        /// </summary>
        [JsonProperty("location")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("location")]
#endif
        public OrderDeliveryDetailLocation Location { get; set; }

        /// <summary>
        /// Quantity of carbon removal supplied by this delivery.
        /// </summary>
        [JsonProperty("metric_tons")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metric_tons")]
#endif
        public string MetricTons { get; set; }

        /// <summary>
        /// Once retired, a URL to the registry entry for the tons from this delivery.
        /// </summary>
        [JsonProperty("registry_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("registry_url")]
#endif
        public string RegistryUrl { get; set; }

        /// <summary>
        /// A supplier of carbon removal.
        /// </summary>
        [JsonProperty("supplier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("supplier")]
#endif
        public Supplier Supplier { get; set; }
    }
}
