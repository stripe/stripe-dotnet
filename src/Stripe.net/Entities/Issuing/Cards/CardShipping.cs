// File generated from our OpenAPI spec
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
        /// One of: <c>dhl</c>, <c>fedex</c>, <c>royal_mail</c>, or <c>usps</c>.
        /// </summary>
        [JsonProperty("carrier")]
        public string Carrier { get; set; }

        /// <summary>
        /// Additional information that may be required for clearing customs.
        /// </summary>
        [JsonProperty("customs")]
        public CardShippingCustoms Customs { get; set; }

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
        /// The phone number of the receiver of the shipment. Our courier partners will use this
        /// number to contact you in the event of card delivery issues. For individual shipments to
        /// the EU/UK, if this field is empty, we will provide them with the phone number provided
        /// when the cardholder was initially created.
        /// </summary>
        [JsonProperty("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether a signature is required for card delivery. This feature is only supported for US
        /// users. Standard shipping service does not support signature on delivery. The default
        /// value for standard shipping service is false and for express and priority services is
        /// true.
        /// </summary>
        [JsonProperty("require_signature")]
        public bool? RequireSignature { get; set; }

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
