// File generated from our OpenAPI spec
namespace Stripe.V2
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationRecipientDataOptions : INestedOptions
    {
        /// <summary>
        /// Features representing the functionality that should be enabled for when this Account is
        /// used as a recipient. Features need to be explicitly requested, and the <c>status</c>
        /// field indicates if the Feature is <c>active</c>, <c>restricted</c> or <c>pending</c>.
        /// Once a Feature is <c>active</c>, the Account can be used with the product flow that the
        /// Feature enables.
        /// </summary>
        [JsonProperty("features")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("features")]
#endif
        public AccountCreateConfigurationRecipientDataFeaturesOptions Features { get; set; }
    }
}
