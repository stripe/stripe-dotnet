namespace Stripe.Terminal
{
    using System;
    using Newtonsoft.Json;

    public class ReaderListOptions : ListOptions
    {
        /// <summary>
        /// A location ID to filter the response list to only readers at the specific location.
        /// </summary>
        [JsonProperty("location")]
        public string Location { get; set; }

        /// <summary>
        /// A status filter to filter readers to only offline or online readers. Possible values
        /// are <c>offline</c> and <c>online</c>.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
