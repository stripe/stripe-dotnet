// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;


    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PaymentMethodUsBankAccountStatusDetails : StripeEntity<PaymentMethodUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
        [STJS.JsonPropertyName("blocked")]
        public PaymentMethodUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
