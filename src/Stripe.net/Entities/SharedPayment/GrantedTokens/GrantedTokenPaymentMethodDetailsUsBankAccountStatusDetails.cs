// File generated from our OpenAPI spec
namespace Stripe.SharedPayment
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class GrantedTokenPaymentMethodDetailsUsBankAccountStatusDetails : StripeEntity<GrantedTokenPaymentMethodDetailsUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
        [STJS.JsonPropertyName("blocked")]
        public GrantedTokenPaymentMethodDetailsUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
