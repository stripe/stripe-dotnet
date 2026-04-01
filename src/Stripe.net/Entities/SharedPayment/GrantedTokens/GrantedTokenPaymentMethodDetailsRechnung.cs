// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsRechnung : StripeEntity<GrantedTokenPaymentMethodDetailsRechnung>
    {
        [JsonProperty("dob")]
        [STJS.JsonPropertyName("dob")]
        public GrantedTokenPaymentMethodDetailsRechnungDob Dob { get; set; }
    }
}
