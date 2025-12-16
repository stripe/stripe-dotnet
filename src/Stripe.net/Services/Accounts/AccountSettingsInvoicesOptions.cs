// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class AccountSettingsInvoicesOptions : INestedOptions
    {
        /// <summary>
        /// The list of default Account Tax IDs to automatically include on invoices. Account Tax
        /// IDs get added when an invoice is finalized.
        /// </summary>
        [JsonProperty("default_account_tax_ids")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("default_account_tax_ids")]
#endif
        public List<string> DefaultAccountTaxIds { get; set; }

        /// <summary>
        /// Whether to save the payment method after a payment is completed for a one-time invoice
        /// or a subscription invoice when the customer already has a default payment method on the
        /// hosted invoice page.
        /// One of: <c>always</c>, <c>never</c>, or <c>offer</c>.
        /// </summary>
        [JsonProperty("hosted_payment_method_save")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("hosted_payment_method_save")]
#endif
        public string HostedPaymentMethodSave { get; set; }
    }
}
