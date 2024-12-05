// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class AccountGroups : StripeEntity<AccountGroups>
    {
        /// <summary>
        /// The group the account is in to determine their payments pricing, and null if the account
        /// is on customized pricing. <a
        /// href="https://stripe.com/docs/connect/platform-pricing-tools">See the Platform pricing
        /// tool documentation</a> for details.
        /// </summary>
        [JsonProperty("payments_pricing")]
        public string PaymentsPricing { get; set; }
    }
}
