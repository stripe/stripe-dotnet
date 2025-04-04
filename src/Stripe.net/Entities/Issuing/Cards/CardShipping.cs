// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardShipping : StripeEntity<CardShipping>
    {
        [JsonProperty("address")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address")]
#endif
        public Address Address { get; set; }

        /// <summary>
        /// Address validation details for the shipment.
        /// </summary>
        [JsonProperty("address_validation")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_validation")]
#endif
        public CardShippingAddressValidation AddressValidation { get; set; }

        /// <summary>
        /// The delivery company that shipped a card.
        /// One of: <c>dhl</c>, <c>fedex</c>, <c>royal_mail</c>, or <c>usps</c>.
        /// </summary>
        [JsonProperty("carrier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("carrier")]
#endif
        public string Carrier { get; set; }

        /// <summary>
        /// Additional information that may be required for clearing customs.
        /// </summary>
        [JsonProperty("customs")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("customs")]
#endif
        public CardShippingCustoms Customs { get; set; }

        /// <summary>
        /// A unix timestamp representing a best estimate of when the card will be delivered.
        /// </summary>
        [JsonProperty("eta")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("eta")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
#endif
        public DateTime? Eta { get; set; }

        /// <summary>
        /// Recipient name.
        /// </summary>
        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif
        public string Name { get; set; }

        /// <summary>
        /// The phone number of the receiver of the shipment. Our courier partners will use this
        /// number to contact you in the event of card delivery issues. For individual shipments to
        /// the EU/UK, if this field is empty, we will provide them with the phone number provided
        /// when the cardholder was initially created.
        /// </summary>
        [JsonProperty("phone_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone_number")]
#endif
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Whether a signature is required for card delivery. This feature is only supported for US
        /// users. Standard shipping service does not support signature on delivery. The default
        /// value for standard shipping service is false and for express and priority services is
        /// true.
        /// </summary>
        [JsonProperty("require_signature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("require_signature")]
#endif
        public bool? RequireSignature { get; set; }

        /// <summary>
        /// Shipment service, such as <c>standard</c> or <c>express</c>.
        /// One of: <c>express</c>, <c>priority</c>, or <c>standard</c>.
        /// </summary>
        [JsonProperty("service")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("service")]
#endif
        public string Service { get; set; }

        /// <summary>
        /// The delivery status of the card.
        /// One of: <c>canceled</c>, <c>delivered</c>, <c>failure</c>, <c>pending</c>,
        /// <c>returned</c>, <c>shipped</c>, or <c>submitted</c>.
        /// </summary>
        [JsonProperty("status")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("status")]
#endif
        public string Status { get; set; }

        /// <summary>
        /// A tracking number for a card shipment.
        /// </summary>
        [JsonProperty("tracking_number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_number")]
#endif
        public string TrackingNumber { get; set; }

        /// <summary>
        /// A link to the shipping carrier's site where you can view detailed information about a
        /// card shipment.
        /// </summary>
        [JsonProperty("tracking_url")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("tracking_url")]
#endif
        public string TrackingUrl { get; set; }

        /// <summary>
        /// Packaging options.
        /// One of: <c>bulk</c>, or <c>individual</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
