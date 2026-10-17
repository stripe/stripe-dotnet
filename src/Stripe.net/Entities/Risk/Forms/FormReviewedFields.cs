// File generated from our OpenAPI spec
namespace Stripe.Risk
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class FormReviewedFields : StripeEntity<FormReviewedFields>
    {
        [JsonProperty("attestation")]
        [STJS.JsonPropertyName("attestation")]
        public FormReviewedFieldsAttestation Attestation { get; set; }
    }
}
