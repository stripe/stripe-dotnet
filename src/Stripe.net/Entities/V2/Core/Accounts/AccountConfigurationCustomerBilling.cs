// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class AccountConfigurationCustomerBilling : StripeEntity<AccountConfigurationCustomerBilling>
    {
        /// <summary>
        /// ID of a PaymentMethod attached to the customer account to use as the default for
        /// invoices and subscriptions.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default invoice settings for the customer account.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public AccountConfigurationCustomerBillingInvoice Invoice { get; set; }
    }
}
