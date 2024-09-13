namespace Stripe
{
#if USE_SYSTEM_TEXT_JSON
    using System.Text.Json.Serialization;
#else
    using Newtonsoft.Json;
#endif

    public class AccountControllerFees : StripeEntity<AccountControllerFees>
    {
        /// <summary>
        /// A value indicating the responsible payer of a bundle of Stripe fees for pricing-control
        /// eligible products on this account. Learn more about <a
        /// href="https://docs.stripe.com/connect/direct-charges-fee-payer-behavior">fee behavior on
        /// connected accounts</a>.
        /// One of: <c>account</c>, <c>application</c>, <c>application_custom</c>, or
        /// <c>application_express</c>.
        /// </summary>
#if USE_SYSTEM_TEXT_JSON
        [JsonPropertyName("payer")]
#else
        [JsonProperty("payer")]
#endif
        public string Payer { get; set; }
    }
}
