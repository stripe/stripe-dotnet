// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsBillSettingsDetailsInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// How long the customer has to pay the invoice before it's past due.
        /// </summary>
        [JsonProperty("time_until_due")]
        [STJS.JsonPropertyName("time_until_due")]
        public ContractCreateBillingSettingsBillSettingsDetailsInvoiceTimeUntilDueOptions TimeUntilDue { get; set; }
    }
}
