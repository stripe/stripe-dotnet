// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class VerificationSessionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://stripe.com/docs/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("metadata")]
#endif
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A set of options for the session’s verification checks.
        /// </summary>
        [JsonProperty("options")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("options")]
#endif
        public VerificationSessionOptionsOptions Options { get; set; }

        /// <summary>
        /// Details provided about the user being verified. These details may be shown to the user.
        /// </summary>
        [JsonProperty("provided_details")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("provided_details")]
#endif
        public VerificationSessionProvidedDetailsOptions ProvidedDetails { get; set; }

        /// <summary>
        /// The type of <a href="https://stripe.com/docs/identity/verification-checks">verification
        /// check</a> to be performed.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
