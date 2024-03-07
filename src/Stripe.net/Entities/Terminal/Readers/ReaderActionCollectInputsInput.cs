// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInput : StripeEntity<ReaderActionCollectInputsInput>
    {
        /// <summary>
        /// Default text of input being collected.
        /// </summary>
        [JsonProperty("custom_text")]
        public ReaderActionCollectInputsInputCustomText CustomText { get; set; }

        /// <summary>
        /// Indicate that this input is required, disabling the skip button.
        /// </summary>
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

        /// <summary>
        /// Indicate that this input was skipped by the user.
        /// </summary>
        [JsonProperty("skipped")]
        public bool Skipped { get; set; }

        /// <summary>
        /// Type of input being collected.
        /// One of: <c>email</c>, <c>numeric</c>, <c>phone</c>, <c>selection</c>, <c>signature</c>,
        /// or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
