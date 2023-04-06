// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentMethodLink : StripeEntity<PaymentMethodLink>
    {
        /// <summary>
        /// Two-letter ISO code representing the funding source (i.e. card, bank) country beneath
        /// the Link payment method. You could use this attribute to get a sense of the
        /// international breakdown of funding sources you've collected.
        /// </summary>
        [JsonProperty("country")]
        public string Country { get; set; }

        /// <summary>
        /// Account owner's email address.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Token used for persistent Link logins.
        /// </summary>
        [JsonProperty("persistent_token")]
        public string PersistentToken { get; set; }
    }
}
