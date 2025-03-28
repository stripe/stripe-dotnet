// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountConfigurationCustomerBilling : StripeEntity<AccountConfigurationCustomerBilling>
    {
        /// <summary>
        /// ID of a payment method that’s attached to the customer, to be used as the customer’s
        /// default payment method for invoices and subscriptions.
        /// </summary>
        [JsonProperty("default_payment_method")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_payment_method")]
#endif
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default settings used on invoices for this customer.
        /// </summary>
        [JsonProperty("invoice")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("invoice")]
#endif
        public AccountConfigurationCustomerBillingInvoice Invoice { get; set; }
    }
}
