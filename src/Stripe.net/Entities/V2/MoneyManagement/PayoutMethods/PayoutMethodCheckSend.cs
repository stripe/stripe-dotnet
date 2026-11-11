// File generated from our OpenAPI spec
namespace Stripe.V2.MoneyManagement
{
    using Newtonsoft.Json;
    using Stripe.Infrastructure;
    using STJS = System.Text.Json.Serialization;

    [STJS.JsonConverter(typeof(STJStripeEntityConverter))]
    public class PayoutMethodCheckSend : StripeEntity<PayoutMethodCheckSend>
    {
        /// <summary>
        /// The US mailing address the check is sent to.
        /// </summary>
        [JsonProperty("mailing_address")]
        [STJS.JsonPropertyName("mailing_address")]
        public PayoutMethodCheckSendMailingAddress MailingAddress { get; set; }

        /// <summary>
        /// The name printed on the check's payee line.
        /// </summary>
        [JsonProperty("payee_name")]
        [STJS.JsonPropertyName("payee_name")]
        public string PayeeName { get; set; }
    }
}
