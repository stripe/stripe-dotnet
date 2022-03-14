// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentLinkPhoneNumberCollection : StripeEntity<PaymentLinkPhoneNumberCollection>
    {
        /// <summary>
        /// If <c>true</c>, a phone number will be collected during checkout.
        /// </summary>
        [JsonProperty("enabled")]
        public bool Enabled { get; set; }
    }
}
