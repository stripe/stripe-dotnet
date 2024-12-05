// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class OrderDeliveryDetail : StripeEntity<OrderDeliveryDetail>
    {
        /// <summary>
        /// Time at which the delivery occurred. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("delivered_at")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime DeliveredAt { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Specific location of this delivery.
        /// </summary>
        [JsonProperty("location")]
        public OrderDeliveryDetailLocation Location { get; set; }

        /// <summary>
        /// Quantity of carbon removal supplied by this delivery.
        /// </summary>
        [JsonProperty("metric_tons")]
        public string MetricTons { get; set; }

        /// <summary>
        /// Once retired, a URL to the registry entry for the tons from this delivery.
        /// </summary>
        [JsonProperty("registry_url")]
        public string RegistryUrl { get; set; }

        /// <summary>
        /// A supplier of carbon removal.
        /// </summary>
        [JsonProperty("supplier")]
        public Supplier Supplier { get; set; }
    }
}
