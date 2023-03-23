// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInputSignature : StripeEntity<ReaderActionCollectInputsInputSignature>
    {
        /// <summary>
        /// The File ID of a collected signature image.
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
