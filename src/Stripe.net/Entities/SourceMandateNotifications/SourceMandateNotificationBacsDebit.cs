// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
#if NET6_0_OR_GREATER
    using STJS = System.Text.Json.Serialization;
#endif

    public class SourceMandateNotificationBacsDebit : StripeEntity<SourceMandateNotificationBacsDebit>
    {
        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
#if NET6_0_OR_GREATER
        [STJS.JsonPropertyName("last4")]
#endif
        public string Last4 { get; set; }
    }
}
