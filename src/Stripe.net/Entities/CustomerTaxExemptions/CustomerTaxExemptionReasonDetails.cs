// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class CustomerTaxExemptionReasonDetails : StripeEntity<CustomerTaxExemptionReasonDetails>
    {
        [JsonProperty("other")]
        [STJS.JsonPropertyName("other")]
        public CustomerTaxExemptionReasonDetailsOther Other { get; set; }
    }
}
