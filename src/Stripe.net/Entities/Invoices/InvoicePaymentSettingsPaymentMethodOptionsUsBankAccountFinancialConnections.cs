// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<InvoicePaymentSettingsPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        /// <summary>
        /// The list of permissions to request. The <c>payment_method</c> permission must be
        /// included.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }
    }
}
