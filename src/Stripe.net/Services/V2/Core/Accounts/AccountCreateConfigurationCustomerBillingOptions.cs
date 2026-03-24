// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountCreateConfigurationCustomerBillingOptions : INestedOptions
    {
        /// <summary>
        /// Default invoice settings for the customer account.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public AccountCreateConfigurationCustomerBillingInvoiceOptions Invoice { get; set; }
    }
}
