// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountUpdateConfigurationCustomerBillingOptions : INestedOptions
    {
        /// <summary>
        /// ID of a PaymentMethod attached to the customer account to use as the default for
        /// invoices and subscriptions.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default invoice settings for the customer account.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public AccountUpdateConfigurationCustomerBillingInvoiceOptions Invoice { get; set; }
    }
}
