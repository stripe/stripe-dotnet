// File generated from our OpenAPI spec
namespace Stripe.V2.Billing
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeOptionsConverter))]
    public class ContractCreateBillingSettingsContractBillingDetailsBillSettingsDetailsInvoiceOptions : INestedOptions
    {
        /// <summary>
        /// The number of time units before the invoice is past due.
        /// </summary>
        [JsonProperty("time_until_due")]
        [STJS.JsonPropertyName("time_until_due")]
        public ContractCreateBillingSettingsContractBillingDetailsBillSettingsDetailsInvoiceTimeUntilDueOptions TimeUntilDue { get; set; }
    }
}
