// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderActionCollectInputsInput : StripeEntity<ReaderActionCollectInputsInput>
    {
        /// <summary>
        /// Default text of input being collected.
        /// </summary>
        [JsonProperty("custom_text")]
        public ReaderActionCollectInputsInputCustomText CustomText { get; set; }

        /// <summary>
        /// Information about a email being collected using a reader.
        /// </summary>
        [JsonProperty("email")]
        public ReaderActionCollectInputsInputEmail Email { get; set; }

        /// <summary>
        /// Information about a number being collected using a reader.
        /// </summary>
        [JsonProperty("numeric")]
        public ReaderActionCollectInputsInputNumeric Numeric { get; set; }

        /// <summary>
        /// Information about a phone number being collected using a reader.
        /// </summary>
        [JsonProperty("phone")]
        public ReaderActionCollectInputsInputPhone Phone { get; set; }

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
        /// Information about text being collected using a reader.
        /// </summary>
        [JsonProperty("text")]
        public ReaderActionCollectInputsInputText Text { get; set; }

        /// <summary>
        /// List of toggles being collected. Values are present if collection is complete.
        /// </summary>
        [JsonProperty("toggles")]
        public List<ReaderActionCollectInputsInputToggle> Toggles { get; set; }

        /// <summary>
        /// Type of input being collected.
        /// One of: <c>email</c>, <c>numeric</c>, <c>phone</c>, <c>selection</c>, <c>signature</c>,
        /// or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
