// File generated from our OpenAPI spec
namespace Stripe.V2.Core
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class AccountUpdateConfigurationCustomerBillingOptions : INestedOptions
    {
        /// <summary>
        /// The ID of a <c>PaymentMethod</c> attached to this Account's <c>customer</c>
        /// configuration, used as the default payment method for invoices and subscriptions.
        /// </summary>
        [JsonProperty("default_payment_method")]
        [STJS.JsonPropertyName("default_payment_method")]
        public string DefaultPaymentMethod { get; set; }

        /// <summary>
        /// Default invoice settings for the customer account.
        /// </summary>
        [JsonProperty("invoice")]
        [STJS.JsonPropertyName("invoice")]
        public AccountUpdateConfigurationCustomerBillingInvoiceOptions Invoice { get; set; }
    }
}
