// File generated from our OpenAPI spec
namespace Stripe
{
    using System;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Location specific customer tax exemptions.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxExemption : StripeEntity<CustomerTaxExemption>, IHasId, IHasObject
    {
        [JsonProperty("id")]
        [STJS.JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        [JsonProperty("ca")]
        [STJS.JsonPropertyName("ca")]
        public CustomerTaxExemptionCa Ca { get; set; }

        [JsonProperty("country")]
        [STJS.JsonPropertyName("country")]
        public string Country { get; set; }

        [JsonProperty("created")]
        [JsonConverter(typeof(UnixDateTimeConverter))]
        [STJS.JsonPropertyName("created")]
        [STJS.JsonConverter(typeof(STJUnixDateTimeConverter))]
        public DateTime Created { get; set; } = Stripe.Infrastructure.DateTimeUtils.UnixEpoch;

        [JsonProperty("customer")]
        [STJS.JsonPropertyName("customer")]
        public string Customer { get; set; }

        /// <summary>
        /// Present and true when the exemption has been deleted.
        /// </summary>
        [JsonProperty("deleted", NullValueHandling = NullValueHandling.Ignore)]
        [STJS.JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

        /// <summary>
        /// ISO 8601 date (YYYY-MM-DD) when the exemption becomes effective.
        /// </summary>
        [JsonProperty("effective_date")]
        [STJS.JsonPropertyName("effective_date")]
        public string EffectiveDate { get; set; }

        /// <summary>
        /// ISO 8601 date (YYYY-MM-DD) when the exemption expires.
        /// </summary>
        [JsonProperty("expiration_date")]
        [STJS.JsonPropertyName("expiration_date")]
        public string ExpirationDate { get; set; }

        [JsonProperty("livemode")]
        [STJS.JsonPropertyName("livemode")]
        public bool Livemode { get; set; }

        [JsonProperty("us")]
        [STJS.JsonPropertyName("us")]
        public CustomerTaxExemptionUs Us { get; set; }
    }
}
