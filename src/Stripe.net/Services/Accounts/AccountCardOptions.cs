// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCardOptions : INestedOptions, IHasMetadata, IHasObject
    {
        [JsonProperty("address_city")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_city")]
#endif

        public string AddressCity { get; set; }

        [JsonProperty("address_country")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_country")]
#endif

        public string AddressCountry { get; set; }

        [JsonProperty("address_line1")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line1")]
#endif

        public string AddressLine1 { get; set; }

        [JsonProperty("address_line2")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_line2")]
#endif

        public string AddressLine2 { get; set; }

        [JsonProperty("address_state")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_state")]
#endif

        public string AddressState { get; set; }

        [JsonProperty("address_zip")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("address_zip")]
#endif

        public string AddressZip { get; set; }

        [JsonProperty("currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("currency")]
#endif

        public string Currency { get; set; }

        [JsonProperty("cvc")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("cvc")]
#endif

        public string Cvc { get; set; }

        [JsonProperty("default_for_currency")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_for_currency")]
#endif

        public bool? DefaultForCurrency { get; set; }

        [JsonProperty("exp_month")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_month")]
#endif

        public long? ExpMonth { get; set; }

        [JsonProperty("exp_year")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("exp_year")]
#endif

        public long? ExpYear { get; set; }

        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif

        public Dictionary<string, string> Metadata { get; set; }

        [JsonProperty("name")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("name")]
#endif

        public string Name { get; set; }

        [JsonProperty("number")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("number")]
#endif

        public string Number { get; set; }

        [JsonProperty("object")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("object")]
#endif

        public string Object { get; set; } = "card";
    }
}
