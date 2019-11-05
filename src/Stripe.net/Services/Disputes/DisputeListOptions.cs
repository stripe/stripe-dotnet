namespace Stripe
{
    using Newtonsoft.Json;

    /// <summary>
    /// The optional arguments you can pass. <a href="https://stripe.com/docs/api#list_disputes">Stripe Documentation</a>.
    /// </summary>
    public class DisputeListOptions : ListOptionsWithCreated
    {
        /// <summary>
        /// Only return disputes that are associated with the Charge specified by this Charge ID.
        /// </summary>
        [JsonProperty("charge")]
        public string Charge { get; set; }
    }
}
