// File generated from our OpenAPI spec
namespace Stripe
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections : StripeEntity<PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnections>
    {
        [JsonProperty("manual_entry")]
        public PaymentIntentPaymentMethodOptionsUsBankAccountFinancialConnectionsManualEntry ManualEntry { get; set; }

        /// <summary>
        /// The list of permissions to request. The <c>payment_method</c> permission must be
        /// included.
        /// </summary>
        [JsonProperty("permissions")]
        public List<string> Permissions { get; set; }

        /// <summary>
        /// Data features requested to be retrieved upon account creation.
        /// </summary>
        [JsonProperty("prefetch")]
        public List<string> Prefetch { get; set; }

        /// <summary>
        /// For webview integrations only. Upon completing OAuth login in the native browser, the
        /// user will be redirected to this URL to return to your app.
        /// </summary>
        [JsonProperty("return_url")]
        public string ReturnUrl { get; set; }
    }
}
