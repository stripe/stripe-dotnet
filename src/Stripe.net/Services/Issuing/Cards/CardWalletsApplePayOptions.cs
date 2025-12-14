// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class CardWalletsApplePayOptions : INestedOptions
    {
        /// <summary>
        /// Query by Apple Pay primary account identifier.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("primary_account_identifier")]
#endif
        public string PrimaryAccountIdentifier { get; set; }
    }
}
