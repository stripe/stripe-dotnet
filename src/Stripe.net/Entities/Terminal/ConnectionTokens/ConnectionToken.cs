namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConnectionToken : StripeEntity<ConnectionToken>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        public string Object { get; set; }

        /// <summary>
        /// The id of the location that this connection token is scoped to.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// Your application should pass this token to the Stripe Terminal SDK.
        /// </summary>
        [JsonProperty("secret")]
        public string Secret { get; set; }
    }
}
