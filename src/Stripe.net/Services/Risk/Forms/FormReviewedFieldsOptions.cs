// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class FormReviewedFieldsOptions : INestedOptions
    {
        /// <summary>
        /// The connected account's attestation that the named account field values are accurate.
        /// Update inaccurate values through the Accounts API before attesting.
        /// </summary>
        [JsonProperty("attestation")]
        [STJS.JsonPropertyName("attestation")]
        public FormReviewedFieldsAttestationOptions Attestation { get; set; }
    }
}
