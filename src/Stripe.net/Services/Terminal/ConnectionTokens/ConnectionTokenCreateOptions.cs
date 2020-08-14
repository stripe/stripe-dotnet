namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ConnectionTokenCreateOptions : BaseOptions
    {
        /// <summary>
        /// The id of the location that this connection token is scoped to. If specified the
        /// connection token will only be usable with readers assigned to that location, otherwise
        /// the connection token will be usable with all readers.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }
    }
}
