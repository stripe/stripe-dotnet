// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountControllerFees : StripeEntity<AccountControllerFees>
    {
        /// <summary>
        /// A value indicating the responsible payer of a bundle of Stripe fees for pricing-control
        /// eligible products on this account.
        /// One of: <c>account</c>, <c>application</c>, <c>application_custom</c>, or
        /// <c>application_express</c>.
        /// </summary>
        [JsonProperty("payer")]
        public string Payer { get; set; }
    }
}
