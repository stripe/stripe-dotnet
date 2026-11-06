// File generated from our OpenAPI spec
namespace Stripe.Tax
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormCreateOptions : BaseOptions
    {
        /// <summary>
        /// Replacement payee details. Cannot be combined with numerical correction fields. Omitted
        /// fields remain unchanged.
        /// </summary>
        [JsonProperty("payee_details")]
        [STJS.JsonPropertyName("payee_details")]
        public FormPayeeDetailsOptions PayeeDetails { get; set; }

        /// <summary>
        /// Whether a second TIN notice was received. Supported for K and MISC forms only; cannot be
        /// supplied without a substantive correction.
        /// </summary>
        [JsonProperty("second_tin_notice")]
        [STJS.JsonPropertyName("second_tin_notice")]
        public bool? SecondTinNotice { get; set; }

        /// <summary>
        /// Replacement numerical values for a 1099-K. Supply only the group matching the original
        /// form. Omitted fields remain unchanged.
        /// </summary>
        [JsonProperty("us_1099_k")]
        [STJS.JsonPropertyName("us_1099_k")]
        public FormUs1099KOptions Us1099K { get; set; }

        /// <summary>
        /// Replacement numerical values for a 1099-MISC. Supply only the group matching the
        /// original form. Omitted fields remain unchanged.
        /// </summary>
        [JsonProperty("us_1099_misc")]
        [STJS.JsonPropertyName("us_1099_misc")]
        public FormUs1099MiscOptions Us1099Misc { get; set; }

        /// <summary>
        /// Replacement numerical values for a 1099-NEC. Supply only the group matching the original
        /// form. Omitted fields remain unchanged.
        /// </summary>
        [JsonProperty("us_1099_nec")]
        [STJS.JsonPropertyName("us_1099_nec")]
        public FormUs1099NecOptions Us1099Nec { get; set; }
    }
}
