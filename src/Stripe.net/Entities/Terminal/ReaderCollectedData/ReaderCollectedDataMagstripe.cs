// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderCollectedDataMagstripe : StripeEntity<ReaderCollectedDataMagstripe>
    {
        /// <summary>
        /// The raw magstripe data collected by the reader.
        /// </summary>
        [JsonProperty("data")]
        public string Data { get; set; }
    }
}
