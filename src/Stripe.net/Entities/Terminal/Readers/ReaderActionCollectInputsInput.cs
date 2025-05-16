// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderActionCollectInputsInput : StripeEntity<ReaderActionCollectInputsInput>
    {
        /// <summary>
        /// Default text of input being collected.
        /// </summary>
        [JsonProperty("custom_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_text")]
#endif
        public ReaderActionCollectInputsInputCustomText CustomText { get; set; }

        /// <summary>
        /// Information about a email being collected using a reader.
        /// </summary>
        [JsonProperty("email")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("email")]
#endif
        public ReaderActionCollectInputsInputEmail Email { get; set; }

        /// <summary>
        /// Information about a number being collected using a reader.
        /// </summary>
        [JsonProperty("numeric")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("numeric")]
#endif
        public ReaderActionCollectInputsInputNumeric Numeric { get; set; }

        /// <summary>
        /// Information about a phone number being collected using a reader.
        /// </summary>
        [JsonProperty("phone")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("phone")]
#endif
        public ReaderActionCollectInputsInputPhone Phone { get; set; }

        /// <summary>
        /// Indicate that this input is required, disabling the skip button.
        /// </summary>
        [JsonProperty("required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required")]
#endif
        public bool? Required { get; set; }

        /// <summary>
        /// Information about a selection being collected using a reader.
        /// </summary>
        [JsonProperty("selection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("selection")]
#endif
        public ReaderActionCollectInputsInputSelection Selection { get; set; }

        /// <summary>
        /// Information about a signature being collected using a reader.
        /// </summary>
        [JsonProperty("signature")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("signature")]
#endif
        public ReaderActionCollectInputsInputSignature Signature { get; set; }

        /// <summary>
        /// Indicate that this input was skipped by the user.
        /// </summary>
        [JsonProperty("skipped")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("skipped")]
#endif
        public bool Skipped { get; set; }

        /// <summary>
        /// Information about text being collected using a reader.
        /// </summary>
        [JsonProperty("text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("text")]
#endif
        public ReaderActionCollectInputsInputText Text { get; set; }

        /// <summary>
        /// List of toggles being collected. Values are present if collection is complete.
        /// </summary>
        [JsonProperty("toggles")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("toggles")]
#endif
        public List<ReaderActionCollectInputsInputToggle> Toggles { get; set; }

        /// <summary>
        /// Type of input being collected.
        /// One of: <c>email</c>, <c>numeric</c>, <c>phone</c>, <c>selection</c>, <c>signature</c>,
        /// or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("type")]
#endif
        public string Type { get; set; }
    }
}
