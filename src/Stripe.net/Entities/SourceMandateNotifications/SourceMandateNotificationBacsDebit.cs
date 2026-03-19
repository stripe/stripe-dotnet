// File generated from our OpenAPI spec
namespace Stripe
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class SourceMandateNotificationBacsDebit : StripeEntity<SourceMandateNotificationBacsDebit>
    {
        /// <summary>
        /// Last 4 digits of the account number associated with the debit.
        /// </summary>
        [JsonProperty("last4")]
        [STJS.JsonPropertyName("last4")]
        public string Last4 { get; set; }
    }
}
