namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;

    public class CardShipping : StripeEntity<CardShipping>
    {
        [JsonProperty("address")]
        public Address Address { get; set; }

        /// <summary>
        /// The delivery company that shipped a card.
        /// One of: <c>fedex</c>, or <c>usps</c>.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// A unix timestamp representing a best estimate of when the card will be delivered.
        /// </summary>
        [JsonProperty("eta")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        public DateTime? Eta { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Shipment service, such as <c>standard</c> or <c>express</c>.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("service")]
        public string Service { get; set; }

        /// <summary>
        /// The delivery status of the card.
        /// One of: <c>canceled</c>, <c>delivered</c>, <c>failure</c>, <c>pending</c>,
        /// <c>returned</c>, or <c>shipped</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// A tracking number for a card shipment.
        /// </summary>
        [JsonProperty("tracking_number")]
        public string TrackingNumber { get; set; }

        /// <summary>
        /// A link to the shipping carrier's site where you can view detailed information about a
        /// card shipment.
        /// </summary>
        [JsonProperty("tracking_url")]
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
