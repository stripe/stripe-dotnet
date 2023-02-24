// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntryOptions : INestedOptions
    {
        /// <summary>
        /// Settings for configuring manual entry of account details.
        /// One of: <c>automatic</c>, or <c>custom</c>.
        /// </summary>
        [JsonProperty("mode")]
        public string Mode { get; set; }
    }
}
