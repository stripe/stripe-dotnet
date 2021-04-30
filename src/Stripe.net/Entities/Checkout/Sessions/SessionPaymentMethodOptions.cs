// File generated from our OpenAPI spec
namespace Stripe.Checkout
{
    using Newtonsoft.Json;

    public class SessionPaymentMethodOptions : StripeEntity<SessionPaymentMethodOptions>
    {
        [JsonProperty("acss_debit")]
        public SessionPaymentMethodOptionsAcssDebit AcssDebit { get; set; }
    }
}
