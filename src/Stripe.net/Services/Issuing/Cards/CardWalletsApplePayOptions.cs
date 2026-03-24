// File generated from our OpenAPI spec
namespace Stripe.Issuing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class CardWalletsApplePayOptions : INestedOptions
    {
        /// <summary>
        /// Query by Apple Pay primary account identifier.
        /// </summary>
        [JsonProperty("primary_account_identifier")]
        [STJS.JsonPropertyName("primary_account_identifier")]
        public string PrimaryAccountIdentifier { get; set; }
    }
}
