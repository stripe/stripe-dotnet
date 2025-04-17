// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class FxQuoteUsageTransferOptions : INestedOptions
    {
        /// <summary>
        /// The Stripe account ID that the funds will be transferred to.
        ///
        /// This field should match the account ID that would be used in the Transfer’s destination
        /// field.
        /// </summary>
        [JsonProperty("destination")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("destination")]
#endif
        public string Destination { get; set; }
    }
}
