// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountRequirementsEntryReference : StripeEntity<AccountRequirementsEntryReference>
    {
        /// <summary>
        /// If <c>inquiry</c> is the type, the inquiry token.
        /// </summary>
        [JsonProperty("inquiry")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("inquiry")]
#endif
        public string Inquiry { get; set; }

        /// <summary>
        /// If <c>resource</c> is the type, the resource token.
        /// </summary>
        [JsonProperty("resource")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("resource")]
#endif
        public string Resource { get; set; }

        /// <summary>
        /// The type of the reference. An additional hash is included with a name matching the type.
        /// It contains additional information specific to the type.
        /// One of: <c>inquiry</c>, or <c>resource</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
