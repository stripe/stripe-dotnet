// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderSetReaderDisplayOptions : BaseOptions
    {
        /// <summary>
        /// Cart.
        /// </summary>
        [JsonProperty("cart")]
        public ReaderCartOptions Cart { get; set; }

        /// <summary>
        /// Type.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
