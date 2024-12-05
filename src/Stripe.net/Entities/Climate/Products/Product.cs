// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    /// <summary>
    /// A Climate product represents a type of carbon removal unit available for reservation.
    /// You can retrieve it to see the current price and availability.
    /// </summary>
    public class Product : StripeEntity<Product>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object. For convenience, Climate product IDs are
        /// human-readable strings that start with <c>climsku_</c>. See <a
        /// href="https://stripe.com/docs/climate/orders/carbon-removal-inventory">carbon removal
        /// inventory</a> for a list of available carbon removal products.
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Current prices for a metric ton of carbon removal in a currency's smallest unit.
        /// </summary>
        [JsonProperty("current_prices_per_metric_ton")]
        public Dictionary<string, ProductCurrentPricesPerMetricTon> CurrentPricesPerMetricTon { get; set; }

        /// <summary>
        /// The year in which the carbon removal is expected to be delivered.
        /// </summary>
        [JsonProperty("delivery_year")]
        public long? DeliveryYear { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The quantity of metric tons available for reservation.
        /// </summary>
        [JsonProperty("metric_tons_available")]
        public decimal MetricTonsAvailable { get; set; }

        /// <summary>
        /// The Climate product's name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// The carbon removal suppliers that fulfill orders for this Climate product.
        /// </summary>
        [JsonProperty("suppliers")]
        public List<Supplier> Suppliers { get; set; }
    }
}
