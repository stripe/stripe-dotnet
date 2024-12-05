// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class ConfirmationTokenPaymentMethodPreviewCardPresentWallet : StripeEntity<ConfirmationTokenPaymentMethodPreviewCardPresentWallet>
    {
        /// <summary>
        /// The type of mobile wallet, one of <c>apple_pay</c>, <c>google_pay</c>,
        /// <c>samsung_pay</c>, or <c>unknown</c>.
        /// One of: <c>apple_pay</c>, <c>google_pay</c>, <c>samsung_pay</c>, or <c>unknown</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
