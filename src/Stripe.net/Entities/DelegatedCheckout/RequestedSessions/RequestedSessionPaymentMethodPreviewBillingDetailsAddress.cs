// File generated from our OpenAPI spec
namespace Stripe.DelegatedCheckout
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class RequestedSessionPaymentMethodPreviewBillingDetailsAddress : StripeEntity<RequestedSessionPaymentMethodPreviewBillingDetailsAddress>
    {
        /// <summary>
        /// City, district, suburb, town, or village.
        /// </summary>
        [JsonProperty("city")]
        [STJS.JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// Two-letter country code (<a href="https://en.wikipedia.org/wiki/ISO_3166-1_alpha-2">ISO
        /// 3166-1 alpha-2</a>).
        /// </summary>
        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// Address line 1, such as the street, PO Box, or company name.
        /// </summary>
        [JsonProperty("line1")]
        [STJS.JsonPropertyName("line1")]
        public string Line1 { get; set; }

        /// <summary>
        /// Address line 2, such as the apartment, suite, unit, or building.
        /// </summary>
        [JsonProperty("line2")]
        [STJS.JsonPropertyName("line2")]
        public string Line2 { get; set; }

        /// <summary>
        /// ZIP or postal code.
        /// </summary>
        [JsonProperty("postal_code")]
        [STJS.JsonPropertyName("postal_code")]
        public string PostalCode { get; set; }

        /// <summary>
        /// State, county, province, or region (<a
        /// href="https://en.wikipedia.org/wiki/ISO_3166-2">ISO 3166-2</a>).
        /// </summary>
        [JsonProperty("state")]
        [STJS.JsonPropertyName("state")]
        public string State { get; set; }
    }
}
