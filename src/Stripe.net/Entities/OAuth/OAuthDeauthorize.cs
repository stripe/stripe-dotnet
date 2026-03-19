namespace Stripe
{
    using Newtonsoft.Json;
    using STJS = System.Text.Json.Serialization;

    public class OAuthDeauthorize : StripeEntity<OAuthDeauthorize>
    {
        /// <summary>
        /// The unique id of the account you have revoked access to, as a string. This is the same
        /// as the <see cref="OAuthDeauthorizeOptions.StripeUserId"/> you passed in. If this is
        /// returned, the revocation was successful.
        /// </summary>
        [JsonProperty("stripe_user_id")]
        [STJS.JsonPropertyName("stripe_user_id")]
        public string StripeUserId { get; set; }
    }
}
