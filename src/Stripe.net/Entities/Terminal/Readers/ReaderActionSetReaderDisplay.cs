// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionSetReaderDisplay : StripeEntity<ReaderActionSetReaderDisplay>
    {
        /// <summary>
        /// Cart object to be displayed by the reader.
        /// </summary>
        [JsonProperty("cart")]
        public ReaderActionSetReaderDisplayCart Cart { get; set; }

        /// <summary>
        /// Type of information to be displayed by the reader.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
