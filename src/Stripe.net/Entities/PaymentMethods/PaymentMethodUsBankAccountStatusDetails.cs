// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodUsBankAccountStatusDetails : StripeEntity<PaymentMethodUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
        public PaymentMethodUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
