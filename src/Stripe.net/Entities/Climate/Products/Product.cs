// File generated from our OpenAPI spec
namespace Stripe.Climate
{
    using System;
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    /// <summary>
    /// A Climate product represents a type of carbon removal unit available for reservation.
    /// You can retrieve it to see the current price and availability.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class Product : StripeEntity<Product>, IHasId, IHasObject
    {
        /// <summary>
        /// Unique identifier for the object. For convenience, Climate product IDs are
        /// human-readable strings that start with <c>climsku_</c>. See <a
        /// href="https://stripe.com/docs/climate/orders/carbon-removal-inventory">carbon removal
        /// inventory</a> for a list of available carbon removal products.
        /// </summary>
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// Time at which the object was created. Measured in seconds since the Unix epoch.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        /// <summary>
        /// Current prices for a metric ton of carbon removal in a currency's smallest unit.
        /// </summary>
        [JsonProperty("current_prices_per_metric_ton")]
        [STJS.JsonPropertyName("current_prices_per_metric_ton")]
        public Dictionary<string, ProductCurrentPricesPerMetricTon> CurrentPricesPerMetricTon { get; set; }

        /// <summary>
        /// The year in which the carbon removal is expected to be delivered.
        /// </summary>
        [JsonProperty("delivery_year")]
        [STJS.JsonPropertyName("delivery_year")]
        public long? DeliveryYear { get; set; }

        /// <summary>
        /// Has the value <c>true</c> if the object exists in live mode or the value <c>false</c> if
        /// the object exists in test mode.
        /// </summary>
        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        /// <summary>
        /// The quantity of metric tons available for reservation.
        /// </summary>
        [JsonProperty("metric_tons_available")]
        [JsonConverter(typeof(DecimalStringConverter))]
        [STJS.JsonNumberHandling(STJS.JsonNumberHandling.AllowReadingFromString | STJS.JsonNumberHandling.WriteAsString)]
        [STJS.JsonPropertyName("metric_tons_available")]
        public decimal MetricTonsAvailable { get; set; }

        /// <summary>
        /// The Climate product's name.
        /// </summary>
        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// The carbon removal suppliers that fulfill orders for this Climate product.
        /// </summary>
        [JsonProperty("suppliers")]
        [STJS.JsonPropertyName("suppliers")]
        public List<Supplier> Suppliers { get; set; }
    }
}
