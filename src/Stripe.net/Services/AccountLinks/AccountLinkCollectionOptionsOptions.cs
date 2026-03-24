// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountLinkCollectionOptionsOptions : INestedOptions
    {
        /// <summary>
        /// Specifies whether the platform collects external account information from connected
        /// accounts during Connect Onboarding. When set to <c>true</c>, the platform only collects
        /// external account information if the connected account has capabilities which require it.
        /// Some capabilities, such as <c>treasury</c>, don't require external account collection.
        /// When set to <c>false</c>, external account collection is skipped. Defaults to
        /// <c>true</c>.
        /// </summary>
        [JsonProperty("external_account_collection")]
        [STJS.JsonPropertyName("external_account_collection")]
        public bool? ExternalAccountCollection { get; set; }

        /// <summary>
        /// Specifies whether the platform collects only currently_due requirements
        /// (<c>currently_due</c>) or both currently_due and eventually_due requirements
        /// (<c>eventually_due</c>). If you don't specify <c>collection_options</c>, the default
        /// value is <c>currently_due</c>.
        /// One of: <c>currently_due</c>, or <c>eventually_due</c>.
        /// </summary>
        [JsonProperty("fields")]
        [STJS.JsonPropertyName("fields")]
        public string Fields { get; set; }

        /// <summary>
        /// Specifies whether the platform collects future_requirements in addition to requirements
        /// in Connect Onboarding. The default value is <c>omit</c>.
        /// One of: <c>include</c>, or <c>omit</c>.
        /// </summary>
        [JsonProperty("future_requirements")]
        [STJS.JsonPropertyName("future_requirements")]
        public string FutureRequirements { get; set; }
    }
}
