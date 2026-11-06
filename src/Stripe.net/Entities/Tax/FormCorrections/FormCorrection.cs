// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    /// <summary>
    /// Corrections to filed tax forms.
    /// </summary>
    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormCorrection : StripeEntity<FormCorrection>, IHasObject
    {
        /// <summary>
        /// String representing the object's type. Objects of the same type share the same value.
        /// </summary>
        [JsonProperty("object")]
        [STJS.JsonPropertyName("object")]
        public string Object { get; set; }

        /// <summary>
        /// The tax forms created by the correction.
        /// </summary>
        [JsonProperty("correction_forms")]
        [STJS.JsonPropertyName("correction_forms")]
        public List<FormCorrectionCorrectionForm> CorrectionForms { get; set; }

        /// <summary>
        /// The original tax form that was corrected.
        /// </summary>
        [JsonProperty("original_form")]
        [STJS.JsonPropertyName("original_form")]
        public string OriginalForm { get; set; }
    }
}
