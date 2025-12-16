// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ProgramCreateOptions : BaseOptions
    {
        /// <summary>
        /// If true, makes the specified program the default for the given account.
        /// </summary>
        [JsonProperty("is_default")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("is_default")]
#endif
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The program to use as the parent for the new program to create.
        /// </summary>
        [JsonProperty("platform_program")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("platform_program")]
#endif
        public string PlatformProgram { get; set; }
    }
}
