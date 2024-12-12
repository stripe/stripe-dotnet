// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class PaymentMethodUsBankAccountStatusDetails : StripeEntity<PaymentMethodUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("blocked")]
#endif
        public PaymentMethodUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
