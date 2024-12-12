namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class OAuthDeauthorizeOptions : BaseOptions
    {
        /// <summary>
        /// The <c>client_id</c> of the application that you'd like to disconnect the account from.
        /// The account must be connected to this application.
        /// </summary>
        [JsonProperty("client_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("client_id")]
#endif
        public string ClientId { get; set; }

        /// <summary>The account you'd like to disconnect from.</summary>
        [JsonProperty("stripe_user_id")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("stripe_user_id")]
#endif
        public string StripeUserId { get; set; }
    }
}
