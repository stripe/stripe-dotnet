// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class ReaderActionCollectInputsInput : StripeEntity<ReaderActionCollectInputsInput>
    {
        /// <summary>
        /// Default text of input being collected.
        /// </summary>
        [JsonProperty("custom_text")]
        [STJS.JsonPropertyName("custom_text")]
        public ReaderActionCollectInputsInputCustomText CustomText { get; set; }

        /// <summary>
        /// Information about a email being collected using a reader.
        /// </summary>
        [JsonProperty("email")]
        [STJS.JsonPropertyName("email")]
        public ReaderActionCollectInputsInputEmail Email { get; set; }

        /// <summary>
        /// Information about a number being collected using a reader.
        /// </summary>
        [JsonProperty("numeric")]
        [STJS.JsonPropertyName("numeric")]
        public ReaderActionCollectInputsInputNumeric Numeric { get; set; }

        /// <summary>
        /// Information about a phone number being collected using a reader.
        /// </summary>
        [JsonProperty("phone")]
        [STJS.JsonPropertyName("phone")]
        public ReaderActionCollectInputsInputPhone Phone { get; set; }

        /// <summary>
        /// Indicate that this input is required, disabling the skip button.
        /// </summary>
        [JsonProperty("required")]
        [STJS.JsonPropertyName("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Information about a selection being collected using a reader.
        /// </summary>
        [JsonProperty("selection")]
        [STJS.JsonPropertyName("selection")]
        public ReaderActionCollectInputsInputSelection Selection { get; set; }

        /// <summary>
        /// Information about a signature being collected using a reader.
        /// </summary>
        [JsonProperty("signature")]
        [STJS.JsonPropertyName("signature")]
        public ReaderActionCollectInputsInputSignature Signature { get; set; }

        /// <summary>
        /// Indicate that this input was skipped by the user.
        /// </summary>
        [JsonProperty("skipped")]
        [STJS.JsonPropertyName("skipped")]
        public bool Skipped { get; set; }

        /// <summary>
        /// Information about text being collected using a reader.
        /// </summary>
        [JsonProperty("text")]
        [STJS.JsonPropertyName("text")]
        public ReaderActionCollectInputsInputText Text { get; set; }

        /// <summary>
        /// List of toggles being collected. Values are present if collection is complete.
        /// </summary>
        [JsonProperty("toggles")]
        [STJS.JsonPropertyName("toggles")]
        public List<ReaderActionCollectInputsInputToggle> Toggles { get; set; }

        /// <summary>
        /// Type of input being collected.
        /// One of: <c>email</c>, <c>numeric</c>, <c>phone</c>, <c>selection</c>, <c>signature</c>,
        /// or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        [STJS.JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
