// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class IntentCreateOptions : BaseOptions
    {
        /// <summary>
        /// Actions to be performed by this Billing Intent.
        /// </summary>
        [JsonProperty("actions")]
        [STJS.JsonPropertyName("actions")]
        public List<IntentCreateActionOptions> Actions { get; set; }

        /// <summary>
        /// ID of an existing Cadence to use.
        /// </summary>
        [JsonProperty("cadence")]
        [STJS.JsonPropertyName("cadence")]
        public string Cadence { get; set; }

        /// <summary>
        /// Data for creating a new Cadence.
        /// </summary>
        [JsonProperty("cadence_data")]
        [STJS.JsonPropertyName("cadence_data")]
        public IntentCreateCadenceDataOptions CadenceData { get; set; }

        /// <summary>
        /// Three-letter ISO currency code, in lowercase. Must be a supported currency.
        /// </summary>
        [JsonProperty("currency")]
        [STJS.JsonPropertyName("currency")]
        public string Currency { get; set; }
    }
}
