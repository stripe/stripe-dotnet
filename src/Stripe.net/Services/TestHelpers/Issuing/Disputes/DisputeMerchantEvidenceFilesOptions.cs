// File generated from our OpenAPI spec
namespace Stripe.TestHelpers.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class DisputeMerchantEvidenceFilesOptions : INestedOptions
    {
        /// <summary>
        /// How many simulated merchant evidence file tokens to attach (between 1 and 12).
        /// </summary>
        [JsonProperty("number_to_generate")]
        [STJS.JsonPropertyName("number_to_generate")]
        public long? NumberToGenerate { get; set; }
    }
}
