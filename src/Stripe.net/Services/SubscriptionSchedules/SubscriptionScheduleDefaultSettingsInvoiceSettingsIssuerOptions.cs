// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;

    public class SubscriptionScheduleDefaultSettingsInvoiceSettingsIssuerOptions : INestedOptions
    {
        /// <summary>
        /// The connected account being referenced when <c>type</c> is <c>account</c>.
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// Type of the account referenced in the request.
        /// One of: <c>account</c>, or <c>self</c>.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
    }
}
