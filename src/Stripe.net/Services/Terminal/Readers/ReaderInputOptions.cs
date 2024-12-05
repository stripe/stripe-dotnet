// File generated from our OpenAPI spec
namespace Stripe.Terminal
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class ReaderInputOptions : INestedOptions
    {
        /// <summary>
        /// Customize the text which will be displayed while collecting this input.
        /// </summary>
        [JsonProperty("custom_text")]
        public ReaderInputCustomTextOptions CustomText { get; set; }

        /// <summary>
        /// Indicate that this input is required, disabling the skip button.
        /// </summary>
        [JsonProperty("required")]
        public bool? Required { get; set; }

        /// <summary>
        /// Options for the <c>selection</c> input.
        /// </summary>
        [JsonProperty("selection")]
        public ReaderInputSelectionOptions Selection { get; set; }

        /// <summary>
        /// List of toggles to be displayed and customization for the toggles.
        /// </summary>
        [JsonProperty("toggles")]
        public List<ReaderInputToggleOptions> Toggles { get; set; }

        /// <summary>
        /// The type of input to collect.
        /// One of: <c>email</c>, <c>numeric</c>, <c>phone</c>, <c>selection</c>, <c>signature</c>,
        /// or <c>text</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
