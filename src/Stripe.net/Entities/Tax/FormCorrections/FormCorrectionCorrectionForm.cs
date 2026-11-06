// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormCorrectionCorrectionForm : StripeEntity<FormCorrectionCorrectionForm>
    {
        /// <summary>
        /// The kind of information changed by this correction.
        /// One of: <c>payee_changed</c>, or <c>totals_changed</c>.
        /// </summary>
        [JsonProperty("correction_type")]
        [STJS.JsonPropertyName("correction_type")]
        public string CorrectionType { get; set; }

        /// <summary>
        /// The corrected tax form.
        /// </summary>
        [JsonProperty("form")]
        [STJS.JsonPropertyName("form")]
        public string Form { get; set; }
    }
}
