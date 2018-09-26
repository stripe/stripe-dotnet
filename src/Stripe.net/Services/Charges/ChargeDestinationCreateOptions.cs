namespace Stripe
{
    using Newtonsoft.Json;

    public class ChargeDestinationCreateOptions : ChargeDestinationOptions
    {
        /// <summary>
        /// ID of an existing, connected stripe account.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }
    }
}
