// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountLinkCollectionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Specifies whether the platform collects only currently_due requirements
        /// (<c>currently_due</c>) or both currently_due and eventually_due requirements
        /// (<c>eventually_due</c>). If you don't specify <c>collection_options</c>, the default
        /// value is <c>currently_due</c>.
        /// One of: <c>currently_due</c>, or <c>eventually_due</c>.
        /// </summary>
        [JsonProperty("fields")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("fields")]
#endif

        public string Fields { get; set; }

        /// <summary>
        /// Specifies whether the platform collects future_requirements in addition to requirements
        /// in Connect Onboarding. The default value is <c>omit</c>.
        /// One of: <c>include</c>, or <c>omit</c>.
        /// </summary>
        [JsonProperty("future_requirements")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("future_requirements")]
#endif

        public string FutureRequirements { get; set; }
    }
}
