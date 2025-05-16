// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class ReaderInputOptions : INestedOptions
    {
        /// <summary>
        /// Customize the text which will be displayed while collecting this input.
        /// </summary>
        [JsonProperty("custom_text")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("custom_text")]
#endif
        public ReaderInputCustomTextOptions CustomText { get; set; }

        /// <summary>
        /// Indicate that this input is required, disabling the skip button.
        /// </summary>
        [JsonProperty("required")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("required")]
#endif
        public bool? Required { get; set; }

        /// <summary>
        /// Options for the <c>selection</c> input.
        /// </summary>
        [JsonProperty("selection")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("selection")]
#endif
        public ReaderInputSelectionOptions Selection { get; set; }

        /// <summary>
        /// List of toggles to be displayed and customization for the toggles.
        /// </summary>
        [JsonProperty("toggles")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("toggles")]
#endif
        public List<ReaderInputToggleOptions> Toggles { get; set; }

        /// <summary>
        /// The type of input to collect.
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
