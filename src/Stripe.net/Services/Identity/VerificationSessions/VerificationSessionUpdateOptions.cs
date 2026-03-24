// File generated from our OpenAPI spec
namespace Stripe.Identity
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class VerificationSessionUpdateOptions : BaseOptions, IHasMetadata
    {
        /// <summary>
        /// Set of <a href="https://docs.stripe.com/api/metadata">key-value pairs</a> that you can
        /// attach to an object. This can be useful for storing additional information about the
        /// object in a structured format. Individual keys can be unset by posting an empty value to
        /// them. All keys can be unset by posting an empty value to <c>metadata</c>.
        /// </summary>
        [JsonProperty("metadata")]
        [STJS.JsonPropertyName("metadata")]
        public Dictionary<string, string> Metadata { get; set; }

        /// <summary>
        /// A set of options for the session’s verification checks.
        /// </summary>
        [JsonProperty("options")]
        [STJS.JsonPropertyName("options")]
        public VerificationSessionOptionsOptions Options { get; set; }

        /// <summary>
        /// Details provided about the user being verified. These details may be shown to the user.
        /// </summary>
        [JsonProperty("provided_details")]
        [STJS.JsonPropertyName("provided_details")]
        public VerificationSessionProvidedDetailsOptions ProvidedDetails { get; set; }

        /// <summary>
        /// The type of <a href="https://docs.stripe.com/identity/verification-checks">verification
        /// check</a> to be performed.
        /// One of: <c>document</c>, or <c>id_number</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
