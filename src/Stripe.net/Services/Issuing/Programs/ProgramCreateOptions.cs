// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ProgramCreateOptions : BaseOptions
    {
        /// <summary>
        /// If true, makes the specified program the default for the given account.
        /// </summary>
        [JsonProperty("is_default")]
        [STJS.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The program to use as the parent for the new program to create.
        /// </summary>
        [JsonProperty("platform_program")]
        [STJS.JsonPropertyName("platform_program")]
        public string PlatformProgram { get; set; }
    }
}
