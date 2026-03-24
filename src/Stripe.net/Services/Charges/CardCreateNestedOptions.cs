// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardCreateNestedOptions : INestedOptions, IHasMetadata, IHasObject
    {
        [JsonProperty("address_city")]
        [STJS.JsonPropertyName("address_city")]
        public string AddressCity { get; set; }

        [JsonProperty("address_country")]
        [STJS.JsonPropertyName("address_country")]
        public string AddressCountry { get; set; }

        [JsonProperty("address_line1")]
        [STJS.JsonPropertyName("address_line1")]
        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
        [STJS.JsonPropertyName("address_line2")]
        public string AddressLine2 { get; set; }

        [JsonProperty("address_state")]
        [STJS.JsonPropertyName("address_state")]
        public string AddressState { get; set; }

        [JsonProperty("address_zip")]
        [STJS.JsonPropertyName("address_zip")]
        public string AddressZip { get; set; }

        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }

        [JsonProperty("cvc")]
        [STJS.JsonPropertyName("cvc")]
        public string Cvc { get; set; }

        [JsonProperty("exp_month")]
        [STJS.JsonPropertyName("exp_month")]
        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
        [STJS.JsonPropertyName("exp_year")]
        public long? ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
        [STJS.JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("number")]
        [STJS.JsonPropertyName("number")]
        public string Number { get; set; }

        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; } = "card";
    }
}
