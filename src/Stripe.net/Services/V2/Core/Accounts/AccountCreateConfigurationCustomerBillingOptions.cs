// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountCreateConfigurationCustomerBillingOptions : INestedOptions
    {
        /// <summary>
        /// Default settings used on invoices for this customer.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public AccountCreateConfigurationCustomerBillingInvoiceOptions Invoice { get; set; }
    }
}
