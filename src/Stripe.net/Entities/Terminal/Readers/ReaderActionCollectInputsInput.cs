// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInput : StripeEntity<ReaderActionCollectInputsInput>
    {
        [JsonProperty("custom_text")]
        public ReaderActionCollectInputsInputCustomText CustomText { get; set; }

        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Information about a selection being collected using a reader.
        /// </summary>
        [JsonProperty("selection")]
        public ReaderActionCollectInputsInputSelection Selection { get; set; }

        /// <summary>
        /// Information about a signature being collected using a reader.
        /// </summary>
        [JsonProperty("signature")]
        public ReaderActionCollectInputsInputSignature Signature { get; set; }

        [JsonProperty("skipped")]
        public bool Skipped { get; set; }

        /// <summary>
        /// Which supported input type will be collected.
        /// One of: <c>selection</c>, or <c>signature</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
