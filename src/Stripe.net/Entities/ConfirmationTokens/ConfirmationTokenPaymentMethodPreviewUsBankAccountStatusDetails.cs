// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetails : StripeEntity<ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetails>
    {
        [JsonProperty("blocked")]
        public ConfirmationTokenPaymentMethodPreviewUsBankAccountStatusDetailsBlocked Blocked { get; set; }
    }
}
