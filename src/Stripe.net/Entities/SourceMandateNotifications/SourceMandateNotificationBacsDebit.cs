// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SourceMandateNotificationBacsDebit : StripeEntity<SourceMandateNotificationBacsDebit>
    {
        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
        public string Last4 { get; set; }
    }
}
